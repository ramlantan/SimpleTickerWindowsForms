using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Utilities;
using System.Configuration;
using System.ComponentModel;

namespace SimpleTickerWindowsForms
{
    public partial class SimpleTickerView : Form
    {
        // Set up window parameters for click-through, transparency, click and drag, etc
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public const uint WS_EX_LAYERED = 0x00080000;
        public const uint WS_EX_TRANSPARENT = 0x00000020;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern uint GetWindowLong(IntPtr hWnd, GWL nIndex);
        [DllImport("user32.dll")]
        public static extern uint SetWindowLong(IntPtr hWnd, GWL nIndex, uint dwNewLong);
        public enum GWL { ExStyle = -20 }

        // Set up base variables
        private Control tickerPanel;
        // Create copy for scrolling loop
        private Control tickerPanelClone;
        private ContextMenu rightClickMenu;
        private SettingsForm settingsForm;
        private Configuration configFile = null;
        private GlobalKeyboardHook gkh;
        private bool firstrun = true;

        public List<List<string>> Tickers { get; set; }
        public Point TickerLocation { get; set; } = new Point(0, 0);
        public string Currency { get; set; } = "USD";
        public string CurrencySymbol { get; set; } = "$";
        //public string TickerSeparator { get; set; } = "";
        public Font TickerFontStyle { get; set; } = new Font("Consolas", 12);

        public bool AlwaysOnTop { get; set; } = true;
        // Makes use of a free form panel, instead of a grid panel if set to true
        public bool FreeFormMode { get; set; } = false;

        public int BorderBuffer { get; set; } = 2;
        public int RowBuffer { get; set; } = 0;
        public int TickerBuffer { get; set; } = 5;

        public Color TickerBackgroundColor = Color.Black;
        public Color TickerFontColor = Color.White;

        public bool ScrollingMode { get; set; } = false;

        public int TickerWidth { get; set; } = 0;

        //public bool Top10Mode { get; set; } = false;
        //public bool CoinbaseMode { get; set; } = false;

        public int RefreshInterval { get; set; } = 5; // In minutes
        
        public SimpleTickerView()
        {
            InitializeComponent();

            rightClickMenu = new ContextMenu();
            gkh = new GlobalKeyboardHook();
            APIPollingTimer = new Timer();
            UIRefreshTimer = new Timer();

            // Initialize window in click-through mode
            uint ex_style = GetWindowLong(Handle, GWL.ExStyle);
            SetWindowLong(Handle, GWL.ExStyle, ex_style | WS_EX_LAYERED | WS_EX_TRANSPARENT);

            // Set ticker default location
            Location = TickerLocation;

            //add control keys to global key hooks
            gkh.HookedKeys.Add(Keys.LControlKey);
            gkh.HookedKeys.Add(Keys.RControlKey);
            gkh.KeyDown += new KeyEventHandler(Gkh_KeyDown);
            gkh.KeyUp += new KeyEventHandler(Gkh_KeyUp);
            
            // Set up right click menu
            rightClickMenu.MenuItems.Add("Settings", new EventHandler(RightClickSettings));
            rightClickMenu.MenuItems.Add("-");
            rightClickMenu.MenuItems.Add("Close", new EventHandler(RightClickClose));
            ContextMenu = rightClickMenu;

            // Initialize all the thing
            PullTheLeverKronk();
        }

        // Main ticker refresh function
        // Loads data from config file, populates labels, updates label text with respective price, 
        // and adjusts all labels for the price data
        public void PullTheLeverKronk()
        {
            Point lastTickerLocation = new Point(BorderBuffer, BorderBuffer);
            Point lastTickerCloneLocation = new Point(0, BorderBuffer);
            Label currentTicker = new Label();
            Label currentTickerClone = new Label();
            tickerPanel = new Control();
            tickerPanelClone = new Panel();
            Tickers = new List<List<string>>();
            
            LoadConfigFile();

            // Make sure all controls are cleared for a fresh start
            Controls.Clear();

            //Set location
            Location = TickerLocation;
            TopMost = AlwaysOnTop;

            //set up ticker panel
            if (FreeFormMode)
            {
                tickerPanel = new Panel
                {
                    Name = "panel1",
                    AutoSize = true
                };

                if (ScrollingMode)
                {
                    tickerPanelClone = new Panel
                    {
                        Name = "panel1clone",
                        AutoSize = true,
                        Font = TickerFontStyle,
                        Location = new Point(0, 0),
                        Margin = new Padding(0, 0, 0, 0),
                        Padding = new Padding(0, BorderBuffer, BorderBuffer, BorderBuffer),
                        BackColor = TickerBackgroundColor,
                        ForeColor = TickerFontColor
                    };
                    tickerPanelClone.MouseDown += SimpleTickerView_MouseDown; // Set all panel mouse down events to be sent to main form mouse down
                    Controls.Add(tickerPanelClone);
                }

                AutoSize = false;
            }
            else
            {
                tickerPanel = new TableLayoutPanel
                {
                    Name = "table1",
                    AutoSize = true,
                    AutoSizeMode = AutoSizeMode.GrowAndShrink
                };
                AutoSize = true;
            }
            tickerPanel.Font = TickerFontStyle;
            tickerPanel.Location = new Point(0, 0);
            tickerPanel.Margin = new Padding(0, 0, 0, 0);
            tickerPanel.Padding = new Padding(BorderBuffer, BorderBuffer, BorderBuffer, BorderBuffer);
            tickerPanel.BackColor = TickerBackgroundColor;
            tickerPanel.ForeColor = TickerFontColor;
            tickerPanel.MouseDown += SimpleTickerView_MouseDown; // Set all panel mouse down events to be sent to main form mouse down
            Controls.Add(tickerPanel);

            // Create base labels for each ticker
            for (var tickerrow = 0; tickerrow < Tickers.Count; tickerrow++)
            {
                for (var tickerindex = 0; tickerindex < Tickers[tickerrow].Count; tickerindex++)
                {
                    currentTicker = new Label
                    {
                        // Name ticker based on "coordinate" in ticker row lists
                        Name = "ticker" + tickerrow + tickerindex,
                        Font = TickerFontStyle,
                        Location = new Point(0, 0),
                        AutoSize = true,
                        // If last ticker in row, set margin right to 0, if last row, set margin bottom to 0
                        Margin = new Padding(0, 0, (tickerindex == Tickers[tickerrow].Count - 1) ? 0 : TickerBuffer, (tickerrow == Tickers.Count - 1) ? 0 : RowBuffer),
                        Padding = new Padding(0, 0, 0, 0)
                    };

                    if (ScrollingMode && FreeFormMode)
                    {
                        currentTickerClone = new Label
                        {
                            // Name ticker based on "coordinate" in ticker row lists
                            Name = "tickerclone" + tickerrow + tickerindex,
                            Font = TickerFontStyle,
                            Location = new Point(0, 0),
                            AutoSize = true,
                            // If last ticker in row, set margin right to 0, if last row, set margin bottom to 0
                            Margin = new Padding(0, 0, (tickerindex == Tickers[tickerrow].Count - 1) ? 0 : TickerBuffer, (tickerrow == Tickers.Count - 1) ? 0 : RowBuffer),
                            Padding = new Padding(0, 0, 0, 0)
                    };
                        currentTickerClone.MouseDown += SimpleTickerView_MouseDown;
                        tickerPanelClone.Controls.Add(currentTickerClone);
                    }

                    // Set all label MouseDown events to be sent to main form's MouseDown
                    currentTicker.MouseDown += SimpleTickerView_MouseDown;
                    tickerPanel.Controls.Add(currentTicker);

                }// End row
            }// End tickers

            // Populate price data and text for labels
            UpdatePrice();

            // Format all labels based on ticker alignment selection
            for (var tickerrow = 0; tickerrow < Tickers.Count; tickerrow++)
            {
                for (var tickerindex = 0; tickerindex < Tickers[tickerrow].Count; tickerindex++)
                {
                    // Get label to be set up
                    currentTicker = tickerPanel.Controls["ticker" + tickerrow + tickerindex] as Label;
                    
                    // Arrange labels into free form panel
                    if (FreeFormMode)
                    {
                        currentTicker.Location = lastTickerLocation;
                        lastTickerLocation.X = currentTicker.Location.X + currentTicker.Width + TickerBuffer;

                        if (ScrollingMode)
                        {
                            currentTickerClone = tickerPanelClone.Controls["tickerclone" + tickerrow + tickerindex] as Label;
                            currentTickerClone.Location = lastTickerCloneLocation;
                            lastTickerCloneLocation.X = currentTickerClone.Location.X + currentTickerClone.Width + TickerBuffer;
                        }
                    }
                    // Else use a grid
                    else
                    {
                        (tickerPanel as TableLayoutPanel).SetCellPosition(currentTicker, new TableLayoutPanelCellPosition(tickerindex, tickerrow));
                    }

                }// End row

                if (FreeFormMode)
                {
                    lastTickerLocation.X = BorderBuffer; //reset last label location for new row
                    lastTickerLocation.Y = currentTicker.Location.Y + currentTicker.Height + RowBuffer;

                    if (ScrollingMode)
                    {
                        lastTickerCloneLocation.X = BorderBuffer;
                        lastTickerCloneLocation.Y = currentTickerClone.Location.Y + currentTickerClone.Height + RowBuffer;
                    }
                }

            }// End tickers

            // Final panel dimensions setup
            if (FreeFormMode)
            {
                Width = (currentTicker.Location.X + currentTicker.Width + BorderBuffer);
                Height = (currentTicker.Location.Y + currentTicker.Height + BorderBuffer);

                if (ScrollingMode)
                {
                    Width = TickerWidth;
                    ScrollingTimer.Enabled = true;
                    tickerPanelClone.Left = tickerPanel.Right + TickerBuffer;
                }
                else
                {
                    ScrollingTimer.Enabled = false;
                }
            }

            // Limit API Polling Interval to no less than 5 minutes, due to CMC API limits
            if (RefreshInterval < 5 || RefreshInterval > 1440) RefreshInterval = 5;
            APIPollingTimer.Interval = RefreshInterval * 60 * 1000; //multiply to milliseconds
        }

        // Every "ApiPollInterval" UpdatePrice() is called
        private void APIPollingTimer_Tick(object sender, EventArgs e) => UpdatePrice();

        // UI is "refreshed" every 10 seconds
        private void UIRefreshTimer_Tick(object sender, EventArgs e)
        {
            // Set form to display topmost every timer refresh, a workaround for forcing the ticker to always display above the taskbar...
            // Also do not set TopMost while settings form is open
            if (AlwaysOnTop == true && settingsForm == null) TopMost = true;
            if (firstrun)
            {
                firstrun = false;
                PullTheLeverKronk();
            }
        }

        // Rate of scrolling
        private void ScrollingTimer_Tick(object sender, EventArgs e)
        {
            // The cloned ticker panel will trail behind the initial panel, or vis versa, to create a looping/scrolling effect
            if (tickerPanel.Left < tickerPanelClone.Left)
            {
                tickerPanel.Left--;
                tickerPanelClone.Left = tickerPanel.Left + tickerPanelClone.Width + TickerBuffer;

                if (tickerPanel.Left < -tickerPanel.Width)
                {
                    tickerPanel.Left = tickerPanelClone.Left + tickerPanelClone.Width;
                }
            }

            if (tickerPanel.Left > tickerPanelClone.Left)
            {
                tickerPanelClone.Left--;
                tickerPanel.Left = tickerPanelClone.Left + tickerPanelClone.Width + TickerBuffer;

                if (tickerPanelClone.Left < -tickerPanelClone.Width)
                {
                    tickerPanelClone.Left = tickerPanel.Left + tickerPanel.Width;
                }
            }
        }

        // Uses PollApi() to update all tickers with their respective price data 
        public void UpdatePrice()
        {
            Label currentTicker = new Label();
            Label currentTickerClone = new Label();
            string customlabel;
            float price;
            string pricedecimals;

            // Set up ticker labels and format
            for (var tickerrow = 0; tickerrow < Tickers.Count; tickerrow++)
            {
                for (var tickerindex = 0; tickerindex < Tickers[tickerrow].Count; tickerindex++)
                {
                    // Get label to be set up
                    currentTicker = tickerPanel.Controls["ticker" + tickerrow + tickerindex] as Label;
                    if (ScrollingMode && FreeFormMode) currentTickerClone = tickerPanelClone.Controls["tickerclone" + tickerrow + tickerindex] as Label;

                    // Set customlabel to users custom label, or if none is present default to the CMC symbol
                    if (Tickers[tickerrow][tickerindex].Contains("="))
                    {
                        customlabel = Tickers[tickerrow][tickerindex].Split('=')[1];
                    }
                    else
                    {
                        customlabel = Tickers[tickerrow][tickerindex];
                    }

                    // Split out custom name from CMC symbol and pass to API request in the wanted currency
                    price = PollAPI(Tickers[tickerrow][tickerindex].Split('=')[0], Currency);
                    
                    // Format numbers based on some essentially random criteria
                    if (Currency.ToUpper() == "BTC" || Currency.ToUpper() == "ETH") {
                        if (price <= .0001) {
                            pricedecimals = "N8";
                        } else {
                            pricedecimals = "N5";
                        }
                    } else if (price < 1) {
                        pricedecimals = "N3";
                    } else if (price > 100) {
                        pricedecimals = "N0";
                    } else {
                        pricedecimals = "N2";
                    }

                    // If first run and first ticker, display message
                    if (firstrun && tickerrow == 0 && tickerindex == 0) 
                    {
                        currentTicker = tickerPanel.Controls["ticker00"] as Label;
                        currentTicker.Text = "Control + click to move. Control + right click for settings.";
                    }
                    // Display blanks in the remainder of tickers if first run
                    else if (firstrun) {
                        currentTicker.Text = "";
                    }
                    // Else normal label updating
                    else
                    {
                        currentTicker.Text = customlabel + " " + CurrencySymbol + price.ToString(pricedecimals);
                        if (ScrollingMode && FreeFormMode) currentTickerClone.Text = customlabel + " " + CurrencySymbol + price.ToString(pricedecimals);
                    }
                }
            }
        }

        // Loads data from config file
        public void LoadConfigFile()
        {
            TypeConverter converter = TypeDescriptor.GetConverter(typeof(Font));
            
            try
            {
                ConfigurationManager.RefreshSection("appSettings");
                
                if (ConfigurationManager.AppSettings["currency"] != "")
                    Currency = ConfigurationManager.AppSettings["currency"];

                CurrencySymbol = ConfigurationManager.AppSettings["currencysymbol"];

                if (ConfigurationManager.AppSettings["font"] != "")
                    TickerFontStyle = (Font)converter.ConvertFromString(ConfigurationManager.AppSettings["font"]);

                if (ConfigurationManager.AppSettings["row"] != "")
                {
                    List<List<string>> _Tickers = new List<List<string>>();
                    List<string> _TickerRow;
                    string[] rows;
                    string rawRows;

                    rawRows = ConfigurationManager.AppSettings["row"].ToString();
                    rows = rawRows.Replace(Environment.NewLine, "|").Split('|');
                        
                    foreach (string row in rows) {
                        if (row != "")
                        {
                            _TickerRow = row.Split(',').ToList();
                                
                            _TickerRow = _TickerRow.Where(i => i != "").ToList();
                            _Tickers.Add(_TickerRow);
                        }
                    }
                    Tickers = _Tickers;
                }
                if (ConfigurationManager.AppSettings["alwaysontop"] != "")
                    AlwaysOnTop = Convert.ToBoolean(ConfigurationManager.AppSettings["alwaysontop"]);
                if (ConfigurationManager.AppSettings["freeformmode"] != "")
                    FreeFormMode = Convert.ToBoolean(ConfigurationManager.AppSettings["freeformmode"]);
                if (ConfigurationManager.AppSettings["borderbuffer"] != "")
                    BorderBuffer = Int32.Parse(ConfigurationManager.AppSettings["borderbuffer"]);
                if (ConfigurationManager.AppSettings["rowbuffer"] != "")
                    RowBuffer = Int32.Parse(ConfigurationManager.AppSettings["rowbuffer"]);
                if (ConfigurationManager.AppSettings["tickerbuffer"] != "")
                    TickerBuffer = Int32.Parse(ConfigurationManager.AppSettings["tickerbuffer"]);

                if (ConfigurationManager.AppSettings["tickerbackgroundcolor"] != "")
                    TickerBackgroundColor = Color.FromArgb(Convert.ToInt32(ConfigurationManager.AppSettings["tickerbackgroundcolor"]));
                if (ConfigurationManager.AppSettings["tickerfontcolor"] != "")
                    TickerFontColor = Color.FromArgb(Convert.ToInt32(ConfigurationManager.AppSettings["tickerfontcolor"]));

                if (ConfigurationManager.AppSettings["scrollingmode"] != "")
                    ScrollingMode = Convert.ToBoolean(ConfigurationManager.AppSettings["scrollingmode"]);

                if (ConfigurationManager.AppSettings["width"] != "")
                    TickerWidth = Int32.Parse(ConfigurationManager.AppSettings["width"]);

                if (ConfigurationManager.AppSettings["screenlocationX"] != ""
                    && ConfigurationManager.AppSettings["screenlocationY"] != "")
                {
                    TickerLocation = new Point(
                        Int32.Parse(ConfigurationManager.AppSettings["screenlocationX"]),
                        Int32.Parse(ConfigurationManager.AppSettings["screenlocationY"])
                    );
                }

                if (ConfigurationManager.AppSettings["refreshinterval"] != null)
                    RefreshInterval = Int32.Parse(ConfigurationManager.AppSettings["refreshinterval"]);
            }
            catch
            {
                // Use default settings
            }
        }

        // Polls CMC API with coin ticker and currency (3 char string), and returns price of the coin in that currency
        private float PollAPI(string ticker, string cur)
        {
            string apiurl;
            string jsonstring;
            JToken coindata;
            float price;

            //set URL of JSON API endpoint
            apiurl = "https://api.coinmarketcap.com/v1/ticker/" + ticker + "/?convert=" + cur;

            //do some JSON ass bullshit
            //i will not be surprised if half of this is not needed
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(apiurl);
                request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                    jsonstring = reader.ReadToEnd();
                coindata = JArray.Parse(jsonstring);

                //format price data based on currency and value
                price = (float)coindata[0].SelectToken("price_" + cur.ToLower());

                return price;
            }
            catch
            {
                // Else return an erroneous price
                return -1f;
            }
        }

        // Right click menu "Close"
        private void RightClickClose(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Right click menu "Settings"
        // Open settings dialog in modal mode
        private void RightClickSettings(object sender, EventArgs e)
        {
            settingsForm = new SettingsForm { TickerForm = this };
            settingsForm.ShowDialog(this);
            // Nullify form after close
            settingsForm = null;
        }

        // Function for moving the window only when a control key is pressed
        private void SimpleTickerView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && ModifierKeys.HasFlag(Keys.Control))
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);

                if (File.Exists(@"./SimpleTicker.exe.config"))
                {
                    // Save screen location to config when ticker is done being moved
                    configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    
                    configFile.AppSettings.Settings["screenlocationX"].Value = Location.X.ToString();
                    configFile.AppSettings.Settings["screenlocationY"].Value = Location.Y.ToString();

                    configFile.Save(ConfigurationSaveMode.Full);
                    ConfigurationManager.RefreshSection("appSettings");
                }
            }
        }

        // These two functions toggle click-through based on global keys registered with the GlobalKeyboardHook
        private void Gkh_KeyUp(object sender, KeyEventArgs e)
        {
            uint ex_style = GetWindowLong(Handle, GWL.ExStyle);
            SetWindowLong(Handle, GWL.ExStyle, ex_style | WS_EX_LAYERED | WS_EX_TRANSPARENT);
        }

        private void Gkh_KeyDown(object sender, KeyEventArgs e)
        {
            uint ex_style = GetWindowLong(Handle, GWL.ExStyle);
            SetWindowLong(Handle, GWL.ExStyle, ex_style & WS_EX_LAYERED);
        }
    }
}

