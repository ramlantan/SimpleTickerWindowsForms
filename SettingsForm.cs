using System;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using System.ComponentModel;
using System.Drawing;

namespace SimpleTickerWindowsForms
{
    public partial class SettingsForm : Form
    {
        public SimpleTickerView TickerForm { get; set; }
        private Configuration Config { get; set; }
        private TypeConverter converter = TypeDescriptor.GetConverter(typeof(Font));

        public SettingsForm()
        {
            InitializeComponent();
        }
        
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            LoadConfigFileData();

            lblWidth.Enabled = radFreeForm.Checked && chkScrollingMode.Checked;
            lblPx4.Enabled = radFreeForm.Checked && chkScrollingMode.Checked;
            numWidth.Enabled = radFreeForm.Checked && chkScrollingMode.Checked;
            chkScrollingMode.Enabled = radFreeForm.Checked;
        }

        private void BtnSettingsOK_Click(object sender, EventArgs e)
        {
            WriteConfigFileData();

            Close();
            Dispose();

            // Force refresh and reload of config settings on main ticker form
            TickerForm.PullTheLeverKronk();
        }
        
        private void BtnSettingsCancel_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }
        
        private void BtnFont_Click(object sender, EventArgs e)
        {
            // Show the dialog
            DialogResult result = fontDialog.ShowDialog();

            // See if OK was pressed.
            if (result == DialogResult.OK)
            {
                TickerForm.TickerFontStyle = fontDialog.Font;

                lblFontNameOutput.Text = TickerForm.TickerFontStyle.Name;
            }
        }
        
        private void BtnTickerBackgroundColor_Click(object sender, EventArgs e)
        {
            // Show the dialog
            DialogResult result = colorTickerBackground.ShowDialog();

            // See if OK was pressed.
            if (result == DialogResult.OK)
            {
                btnTickerBackgroundColor.BackColor = colorTickerBackground.Color;
            }
        }

        private void BtnTickerFontColor_Click(object sender, EventArgs e)
        {
            // Show the dialog
            DialogResult result = colorTickerFont.ShowDialog();

            // See if OK was pressed.
            if (result == DialogResult.OK)
            {
                btnTickerFontColor.BackColor = colorTickerFont.Color;
            }
        }


        private void LoadConfigFileData()
        {
            if (File.Exists(@"./SimpleTicker.exe.config"))
            {
                ConfigurationManager.RefreshSection("appSettings");

                if (ConfigurationManager.AppSettings["currency"] != "")
                    txtCurrency.Text = ConfigurationManager.AppSettings["currency"];

                txtCurrencySymbol.Text = ConfigurationManager.AppSettings["currencysymbol"];

                if (ConfigurationManager.AppSettings["font"] != "")
                {
                    fontDialog.Font = (Font)converter.ConvertFromString(ConfigurationManager.AppSettings["font"]);
                    lblFontNameOutput.Text = fontDialog.Font.Name;
                }

                if (ConfigurationManager.AppSettings["row"] != "")
                    txtRows.Text = ConfigurationManager.AppSettings["row"];

                if (ConfigurationManager.AppSettings["alwaysontop"] != "")
                    chkAlwaysOnTop.Checked = Convert.ToBoolean(ConfigurationManager.AppSettings["alwaysontop"]);
                if (ConfigurationManager.AppSettings["freeformmode"] != "")
                    radFreeForm.Checked = Convert.ToBoolean(ConfigurationManager.AppSettings["freeformmode"]);

                if (ConfigurationManager.AppSettings["borderbuffer"] != "")
                    numBorderBuffer.Value = Convert.ToInt32(ConfigurationManager.AppSettings["borderbuffer"]);
                if (ConfigurationManager.AppSettings["rowbuffer"] != "")
                    numRowBuffer.Value = Convert.ToInt32(ConfigurationManager.AppSettings["rowbuffer"]);
                if (ConfigurationManager.AppSettings["tickerbuffer"] != "")
                    numTickerBuffer.Value = Convert.ToInt32(ConfigurationManager.AppSettings["tickerbuffer"]);

                if (ConfigurationManager.AppSettings["tickerbackgroundcolor"] != "")
                {
                    btnTickerBackgroundColor.BackColor = Color.FromArgb(Convert.ToInt32(ConfigurationManager.AppSettings["tickerbackgroundcolor"]));
                }
                if (ConfigurationManager.AppSettings["tickerfontcolor"] != "")
                {
                    btnTickerFontColor.BackColor = Color.FromArgb(Convert.ToInt32(ConfigurationManager.AppSettings["tickerfontcolor"]));
                }

                if (ConfigurationManager.AppSettings["scrollingmode"] != "")
                    chkScrollingMode.Checked = Convert.ToBoolean(ConfigurationManager.AppSettings["scrollingmode"]);

                if (ConfigurationManager.AppSettings["width"] != "")
                    numWidth.Value = Int32.Parse(ConfigurationManager.AppSettings["width"]);

                if (ConfigurationManager.AppSettings["refreshinterval"] != "")
                    numRefreshInterval.Value = Convert.ToInt32(ConfigurationManager.AppSettings["refreshinterval"]);

                if (ConfigurationManager.AppSettings["screenlocationX"] != "")
                    txtScreenLocationX.Text = ConfigurationManager.AppSettings["screenlocationX"];
                if (ConfigurationManager.AppSettings["screenlocationY"] != "")
                    txtScreenLocationY.Text = ConfigurationManager.AppSettings["screenlocationY"];

            }
        }

        private void WriteConfigFileData()
        {
            try
            {
                ConfigurationManager.RefreshSection("appSettings");
                Config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            
                // Write sum data
                Config.AppSettings.Settings["currency"].Value = txtCurrency.Text;
                Config.AppSettings.Settings["currencysymbol"].Value = txtCurrencySymbol.Text;

                Config.AppSettings.Settings["font"].Value = converter.ConvertToString(TickerForm.TickerFontStyle);
                
                Config.AppSettings.Settings["row"].Value = txtRows.Text;

                Config.AppSettings.Settings["alwaysontop"].Value = chkAlwaysOnTop.Checked.ToString();
                Config.AppSettings.Settings["freeformmode"].Value = radFreeForm.Checked.ToString();

                Config.AppSettings.Settings["borderbuffer"].Value = numBorderBuffer.Value.ToString();
                Config.AppSettings.Settings["rowbuffer"].Value = numRowBuffer.Value.ToString();
                Config.AppSettings.Settings["tickerbuffer"].Value = numTickerBuffer.Value.ToString();

                Config.AppSettings.Settings["scrollingmode"].Value = chkScrollingMode.Checked.ToString();

                Config.AppSettings.Settings["width"].Value = numWidth.Value.ToString();

                Config.AppSettings.Settings["tickerbackgroundcolor"].Value = btnTickerBackgroundColor.BackColor.ToArgb().ToString();
                Config.AppSettings.Settings["tickerfontcolor"].Value = btnTickerFontColor.BackColor.ToArgb().ToString();

                Config.AppSettings.Settings["refreshinterval"].Value = numRefreshInterval.Value.ToString();

                Config.AppSettings.Settings["screenlocationX"].Value = txtScreenLocationX.Text;
                Config.AppSettings.Settings["screenlocationY"].Value = txtScreenLocationY.Text;

                Config.Save(ConfigurationSaveMode.Full);
            }
            catch
            {
                // Do nothing
                // Leaves default text values
            }
        }

        private void ChkScrollingMode_Click(object sender, EventArgs e)
        {
            lblWidth.Enabled = chkScrollingMode.Checked;
            lblPx4.Enabled = chkScrollingMode.Checked;
            numWidth.Enabled = chkScrollingMode.Checked;
        }

        private void RadFreeForm_CheckedChanged(object sender, EventArgs e)
        {
            chkScrollingMode.Enabled = radFreeForm.Checked;
            if (chkScrollingMode.Checked)
            {
                lblWidth.Enabled = radFreeForm.Checked;
                lblPx4.Enabled = radFreeForm.Checked;
                numWidth.Enabled = radFreeForm.Checked;
            }
        }
    }
}
