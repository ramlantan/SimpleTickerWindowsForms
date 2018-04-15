namespace SimpleTickerWindowsForms
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.btnSettingsOK = new System.Windows.Forms.Button();
            this.btnSettingsCancel = new System.Windows.Forms.Button();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.txtCurrency = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtCurrencySymbol = new System.Windows.Forms.TextBox();
            this.lblCurrencySymbol = new System.Windows.Forms.Label();
            this.chkAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.lblBorderBuffer = new System.Windows.Forms.Label();
            this.lblRowBuffer = new System.Windows.Forms.Label();
            this.lblTickerBuffer = new System.Windows.Forms.Label();
            this.lblPx1 = new System.Windows.Forms.Label();
            this.lblPx2 = new System.Windows.Forms.Label();
            this.lblPx3 = new System.Windows.Forms.Label();
            this.lblScreenLocation = new System.Windows.Forms.Label();
            this.txtScreenLocationX = new System.Windows.Forms.TextBox();
            this.txtScreenLocationY = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.lblRows = new System.Windows.Forms.Label();
            this.lblRefreshInterval = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.grpAlignment = new System.Windows.Forms.GroupBox();
            this.lblPx4 = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.chkScrollingMode = new System.Windows.Forms.CheckBox();
            this.radFreeForm = new System.Windows.Forms.RadioButton();
            this.radTable = new System.Windows.Forms.RadioButton();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.btnFont = new System.Windows.Forms.Button();
            this.lblFontNameOutput = new System.Windows.Forms.Label();
            this.colorTickerBackground = new System.Windows.Forms.ColorDialog();
            this.lblTickerBackgroundColor = new System.Windows.Forms.Label();
            this.lblTickerFontColor = new System.Windows.Forms.Label();
            this.btnTickerBackgroundColor = new System.Windows.Forms.Button();
            this.btnTickerFontColor = new System.Windows.Forms.Button();
            this.colorTickerFont = new System.Windows.Forms.ColorDialog();
            this.trackFontColorTransparency = new System.Windows.Forms.TrackBar();
            this.lblTransparency1 = new System.Windows.Forms.Label();
            this.trackBackgroundColorTransparency = new System.Windows.Forms.TrackBar();
            this.lblTransparency2 = new System.Windows.Forms.Label();
            this.numBorderBuffer = new System.Windows.Forms.NumericUpDown();
            this.numRowBuffer = new System.Windows.Forms.NumericUpDown();
            this.numTickerBuffer = new System.Windows.Forms.NumericUpDown();
            this.numRefreshInterval = new System.Windows.Forms.NumericUpDown();
            this.grpBuffers = new System.Windows.Forms.GroupBox();
            this.grpStyle = new System.Windows.Forms.GroupBox();
            this.lblTickerFormatInstructions = new System.Windows.Forms.Label();
            this.grpAlignment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackFontColorTransparency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBackgroundColorTransparency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBorderBuffer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRowBuffer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTickerBuffer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRefreshInterval)).BeginInit();
            this.grpBuffers.SuspendLayout();
            this.grpStyle.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSettingsOK
            // 
            this.btnSettingsOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSettingsOK.Location = new System.Drawing.Point(439, 382);
            this.btnSettingsOK.Name = "btnSettingsOK";
            this.btnSettingsOK.Size = new System.Drawing.Size(75, 23);
            this.btnSettingsOK.TabIndex = 0;
            this.btnSettingsOK.Text = "OK";
            this.btnSettingsOK.UseVisualStyleBackColor = true;
            this.btnSettingsOK.Click += new System.EventHandler(this.BtnSettingsOK_Click);
            // 
            // btnSettingsCancel
            // 
            this.btnSettingsCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSettingsCancel.Location = new System.Drawing.Point(520, 382);
            this.btnSettingsCancel.Name = "btnSettingsCancel";
            this.btnSettingsCancel.Size = new System.Drawing.Size(75, 23);
            this.btnSettingsCancel.TabIndex = 1;
            this.btnSettingsCancel.Text = "Cancel";
            this.btnSettingsCancel.UseVisualStyleBackColor = true;
            this.btnSettingsCancel.Click += new System.EventHandler(this.BtnSettingsCancel_Click);
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Location = new System.Drawing.Point(12, 16);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(49, 13);
            this.lblCurrency.TabIndex = 2;
            this.lblCurrency.Text = "Currency";
            // 
            // txtCurrency
            // 
            this.txtCurrency.Location = new System.Drawing.Point(67, 13);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Size = new System.Drawing.Size(42, 20);
            this.txtCurrency.TabIndex = 3;
            this.txtCurrency.Text = "USD";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(4, 30);
            this.linkLabel1.Location = new System.Drawing.Point(12, 42);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(378, 30);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "See https://coinmarketcap.com/api/ for valid currencies.\r\nBTC and ETH are also va" +
    "lid currencies, for displaying price in sats or gwei.";
            this.linkLabel1.UseCompatibleTextRendering = true;
            // 
            // txtCurrencySymbol
            // 
            this.txtCurrencySymbol.Location = new System.Drawing.Point(207, 13);
            this.txtCurrencySymbol.Name = "txtCurrencySymbol";
            this.txtCurrencySymbol.Size = new System.Drawing.Size(34, 20);
            this.txtCurrencySymbol.TabIndex = 6;
            this.txtCurrencySymbol.Text = "$";
            // 
            // lblCurrencySymbol
            // 
            this.lblCurrencySymbol.AutoSize = true;
            this.lblCurrencySymbol.Location = new System.Drawing.Point(115, 16);
            this.lblCurrencySymbol.Name = "lblCurrencySymbol";
            this.lblCurrencySymbol.Size = new System.Drawing.Size(86, 13);
            this.lblCurrencySymbol.TabIndex = 5;
            this.lblCurrencySymbol.Text = "Currency Symbol";
            // 
            // chkAlwaysOnTop
            // 
            this.chkAlwaysOnTop.AutoSize = true;
            this.chkAlwaysOnTop.Checked = true;
            this.chkAlwaysOnTop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAlwaysOnTop.Location = new System.Drawing.Point(504, 15);
            this.chkAlwaysOnTop.Name = "chkAlwaysOnTop";
            this.chkAlwaysOnTop.Size = new System.Drawing.Size(92, 17);
            this.chkAlwaysOnTop.TabIndex = 12;
            this.chkAlwaysOnTop.Text = "Always on top";
            this.chkAlwaysOnTop.UseVisualStyleBackColor = true;
            // 
            // lblBorderBuffer
            // 
            this.lblBorderBuffer.AutoSize = true;
            this.lblBorderBuffer.Location = new System.Drawing.Point(17, 23);
            this.lblBorderBuffer.Name = "lblBorderBuffer";
            this.lblBorderBuffer.Size = new System.Drawing.Size(69, 13);
            this.lblBorderBuffer.TabIndex = 13;
            this.lblBorderBuffer.Text = "Border Buffer";
            // 
            // lblRowBuffer
            // 
            this.lblRowBuffer.AutoSize = true;
            this.lblRowBuffer.Location = new System.Drawing.Point(26, 49);
            this.lblRowBuffer.Name = "lblRowBuffer";
            this.lblRowBuffer.Size = new System.Drawing.Size(60, 13);
            this.lblRowBuffer.TabIndex = 15;
            this.lblRowBuffer.Text = "Row Buffer";
            // 
            // lblTickerBuffer
            // 
            this.lblTickerBuffer.AutoSize = true;
            this.lblTickerBuffer.Location = new System.Drawing.Point(18, 75);
            this.lblTickerBuffer.Name = "lblTickerBuffer";
            this.lblTickerBuffer.Size = new System.Drawing.Size(68, 13);
            this.lblTickerBuffer.TabIndex = 17;
            this.lblTickerBuffer.Text = "Ticker Buffer";
            // 
            // lblPx1
            // 
            this.lblPx1.AutoSize = true;
            this.lblPx1.Location = new System.Drawing.Point(141, 22);
            this.lblPx1.Name = "lblPx1";
            this.lblPx1.Size = new System.Drawing.Size(18, 13);
            this.lblPx1.TabIndex = 19;
            this.lblPx1.Text = "px";
            // 
            // lblPx2
            // 
            this.lblPx2.AutoSize = true;
            this.lblPx2.Location = new System.Drawing.Point(141, 49);
            this.lblPx2.Name = "lblPx2";
            this.lblPx2.Size = new System.Drawing.Size(18, 13);
            this.lblPx2.TabIndex = 20;
            this.lblPx2.Text = "px";
            // 
            // lblPx3
            // 
            this.lblPx3.AutoSize = true;
            this.lblPx3.Location = new System.Drawing.Point(141, 75);
            this.lblPx3.Name = "lblPx3";
            this.lblPx3.Size = new System.Drawing.Size(18, 13);
            this.lblPx3.TabIndex = 21;
            this.lblPx3.Text = "px";
            // 
            // lblScreenLocation
            // 
            this.lblScreenLocation.AutoSize = true;
            this.lblScreenLocation.Location = new System.Drawing.Point(456, 42);
            this.lblScreenLocation.Name = "lblScreenLocation";
            this.lblScreenLocation.Size = new System.Drawing.Size(140, 13);
            this.lblScreenLocation.TabIndex = 22;
            this.lblScreenLocation.Text = "Screen Location (automatic)";
            // 
            // txtScreenLocationX
            // 
            this.txtScreenLocationX.Location = new System.Drawing.Point(477, 61);
            this.txtScreenLocationX.Name = "txtScreenLocationX";
            this.txtScreenLocationX.Size = new System.Drawing.Size(40, 20);
            this.txtScreenLocationX.TabIndex = 23;
            this.txtScreenLocationX.Text = "0";
            // 
            // txtScreenLocationY
            // 
            this.txtScreenLocationY.Location = new System.Drawing.Point(552, 61);
            this.txtScreenLocationY.Name = "txtScreenLocationY";
            this.txtScreenLocationY.Size = new System.Drawing.Size(40, 20);
            this.txtScreenLocationY.TabIndex = 24;
            this.txtScreenLocationY.Text = "0";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(457, 64);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 13);
            this.lblX.TabIndex = 25;
            this.lblX.Text = "X";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(532, 64);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(14, 13);
            this.lblY.TabIndex = 26;
            this.lblY.Text = "Y";
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(12, 280);
            this.txtRows.Multiline = true;
            this.txtRows.Name = "txtRows";
            this.txtRows.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRows.Size = new System.Drawing.Size(583, 96);
            this.txtRows.TabIndex = 27;
            this.txtRows.WordWrap = false;
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(9, 212);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(67, 13);
            this.lblRows.TabIndex = 28;
            this.lblRows.Text = "Ticker Rows";
            // 
            // lblRefreshInterval
            // 
            this.lblRefreshInterval.AutoSize = true;
            this.lblRefreshInterval.Location = new System.Drawing.Point(290, 16);
            this.lblRefreshInterval.Name = "lblRefreshInterval";
            this.lblRefreshInterval.Size = new System.Drawing.Size(70, 13);
            this.lblRefreshInterval.TabIndex = 29;
            this.lblRefreshInterval.Text = "Refresh Rate";
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Location = new System.Drawing.Point(417, 16);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(43, 13);
            this.lblMinutes.TabIndex = 30;
            this.lblMinutes.Text = "minutes";
            // 
            // grpAlignment
            // 
            this.grpAlignment.Controls.Add(this.lblPx4);
            this.grpAlignment.Controls.Add(this.lblWidth);
            this.grpAlignment.Controls.Add(this.numWidth);
            this.grpAlignment.Controls.Add(this.chkScrollingMode);
            this.grpAlignment.Controls.Add(this.radFreeForm);
            this.grpAlignment.Controls.Add(this.radTable);
            this.grpAlignment.Location = new System.Drawing.Point(260, 87);
            this.grpAlignment.Name = "grpAlignment";
            this.grpAlignment.Size = new System.Drawing.Size(159, 105);
            this.grpAlignment.TabIndex = 32;
            this.grpAlignment.TabStop = false;
            this.grpAlignment.Text = "Ticker Alignment";
            // 
            // lblPx4
            // 
            this.lblPx4.AutoSize = true;
            this.lblPx4.Location = new System.Drawing.Point(130, 78);
            this.lblPx4.Name = "lblPx4";
            this.lblPx4.Size = new System.Drawing.Size(18, 13);
            this.lblPx4.TabIndex = 43;
            this.lblPx4.Text = "px";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(34, 80);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(35, 13);
            this.lblWidth.TabIndex = 45;
            this.lblWidth.Text = "Width";
            // 
            // numWidth
            // 
            this.numWidth.Location = new System.Drawing.Point(75, 75);
            this.numWidth.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(49, 20);
            this.numWidth.TabIndex = 44;
            // 
            // chkScrollingMode
            // 
            this.chkScrollingMode.AutoSize = true;
            this.chkScrollingMode.Checked = true;
            this.chkScrollingMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkScrollingMode.Location = new System.Drawing.Point(37, 57);
            this.chkScrollingMode.Name = "chkScrollingMode";
            this.chkScrollingMode.Size = new System.Drawing.Size(66, 17);
            this.chkScrollingMode.TabIndex = 43;
            this.chkScrollingMode.Text = "Scrolling";
            this.chkScrollingMode.UseVisualStyleBackColor = true;
            this.chkScrollingMode.Click += new System.EventHandler(this.ChkScrollingMode_Click);
            // 
            // radFreeForm
            // 
            this.radFreeForm.AutoSize = true;
            this.radFreeForm.Location = new System.Drawing.Point(17, 38);
            this.radFreeForm.Name = "radFreeForm";
            this.radFreeForm.Size = new System.Drawing.Size(69, 17);
            this.radFreeForm.TabIndex = 1;
            this.radFreeForm.Text = "Free form";
            this.radFreeForm.UseVisualStyleBackColor = true;
            this.radFreeForm.CheckedChanged += new System.EventHandler(this.RadFreeForm_CheckedChanged);
            // 
            // radTable
            // 
            this.radTable.AutoSize = true;
            this.radTable.Checked = true;
            this.radTable.Location = new System.Drawing.Point(17, 19);
            this.radTable.Name = "radTable";
            this.radTable.Size = new System.Drawing.Size(86, 17);
            this.radTable.TabIndex = 0;
            this.radTable.TabStop = true;
            this.radTable.Text = "Aligned table";
            this.radTable.UseVisualStyleBackColor = true;
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(19, 19);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(61, 23);
            this.btnFont.TabIndex = 33;
            this.btnFont.Text = "Font...";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.BtnFont_Click);
            // 
            // lblFontNameOutput
            // 
            this.lblFontNameOutput.AutoSize = true;
            this.lblFontNameOutput.Location = new System.Drawing.Point(86, 23);
            this.lblFontNameOutput.Name = "lblFontNameOutput";
            this.lblFontNameOutput.Size = new System.Drawing.Size(56, 13);
            this.lblFontNameOutput.TabIndex = 34;
            this.lblFontNameOutput.Text = "FontName";
            // 
            // lblTickerBackgroundColor
            // 
            this.lblTickerBackgroundColor.AutoSize = true;
            this.lblTickerBackgroundColor.Location = new System.Drawing.Point(16, 51);
            this.lblTickerBackgroundColor.Name = "lblTickerBackgroundColor";
            this.lblTickerBackgroundColor.Size = new System.Drawing.Size(98, 13);
            this.lblTickerBackgroundColor.TabIndex = 35;
            this.lblTickerBackgroundColor.Text = "Ticker Background";
            // 
            // lblTickerFontColor
            // 
            this.lblTickerFontColor.AutoSize = true;
            this.lblTickerFontColor.Location = new System.Drawing.Point(16, 75);
            this.lblTickerFontColor.Name = "lblTickerFontColor";
            this.lblTickerFontColor.Size = new System.Drawing.Size(55, 13);
            this.lblTickerFontColor.TabIndex = 36;
            this.lblTickerFontColor.Text = "Font Color";
            // 
            // btnTickerBackgroundColor
            // 
            this.btnTickerBackgroundColor.BackColor = System.Drawing.Color.Black;
            this.btnTickerBackgroundColor.Location = new System.Drawing.Point(134, 46);
            this.btnTickerBackgroundColor.Name = "btnTickerBackgroundColor";
            this.btnTickerBackgroundColor.Size = new System.Drawing.Size(24, 23);
            this.btnTickerBackgroundColor.TabIndex = 37;
            this.btnTickerBackgroundColor.UseVisualStyleBackColor = false;
            this.btnTickerBackgroundColor.Click += new System.EventHandler(this.BtnTickerBackgroundColor_Click);
            // 
            // btnTickerFontColor
            // 
            this.btnTickerFontColor.BackColor = System.Drawing.Color.White;
            this.btnTickerFontColor.Location = new System.Drawing.Point(134, 70);
            this.btnTickerFontColor.Name = "btnTickerFontColor";
            this.btnTickerFontColor.Size = new System.Drawing.Size(24, 23);
            this.btnTickerFontColor.TabIndex = 38;
            this.btnTickerFontColor.UseVisualStyleBackColor = false;
            this.btnTickerFontColor.Click += new System.EventHandler(this.BtnTickerFontColor_Click);
            // 
            // trackFontColorTransparency
            // 
            this.trackFontColorTransparency.AutoSize = false;
            this.trackFontColorTransparency.Location = new System.Drawing.Point(277, 388);
            this.trackFontColorTransparency.Maximum = 255;
            this.trackFontColorTransparency.Name = "trackFontColorTransparency";
            this.trackFontColorTransparency.Size = new System.Drawing.Size(88, 27);
            this.trackFontColorTransparency.TabIndex = 39;
            this.trackFontColorTransparency.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackFontColorTransparency.Visible = false;
            this.trackFontColorTransparency.Scroll += new System.EventHandler(this.TrackFontColorTransparency_Scroll);
            // 
            // lblTransparency1
            // 
            this.lblTransparency1.AutoSize = true;
            this.lblTransparency1.Location = new System.Drawing.Point(207, 383);
            this.lblTransparency1.Name = "lblTransparency1";
            this.lblTransparency1.Size = new System.Drawing.Size(72, 13);
            this.lblTransparency1.TabIndex = 40;
            this.lblTransparency1.Text = "Transparency";
            this.lblTransparency1.Visible = false;
            // 
            // trackBackgroundColorTransparency
            // 
            this.trackBackgroundColorTransparency.AutoSize = false;
            this.trackBackgroundColorTransparency.Location = new System.Drawing.Point(275, 378);
            this.trackBackgroundColorTransparency.Maximum = 255;
            this.trackBackgroundColorTransparency.Name = "trackBackgroundColorTransparency";
            this.trackBackgroundColorTransparency.Size = new System.Drawing.Size(88, 27);
            this.trackBackgroundColorTransparency.TabIndex = 41;
            this.trackBackgroundColorTransparency.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBackgroundColorTransparency.Value = 255;
            this.trackBackgroundColorTransparency.Visible = false;
            this.trackBackgroundColorTransparency.Scroll += new System.EventHandler(this.TrackBackgroundColorTransparency_Scroll);
            // 
            // lblTransparency2
            // 
            this.lblTransparency2.AutoSize = true;
            this.lblTransparency2.Location = new System.Drawing.Point(209, 393);
            this.lblTransparency2.Name = "lblTransparency2";
            this.lblTransparency2.Size = new System.Drawing.Size(72, 13);
            this.lblTransparency2.TabIndex = 42;
            this.lblTransparency2.Text = "Transparency";
            this.lblTransparency2.Visible = false;
            // 
            // numBorderBuffer
            // 
            this.numBorderBuffer.Location = new System.Drawing.Point(92, 20);
            this.numBorderBuffer.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numBorderBuffer.Name = "numBorderBuffer";
            this.numBorderBuffer.Size = new System.Drawing.Size(45, 20);
            this.numBorderBuffer.TabIndex = 43;
            // 
            // numRowBuffer
            // 
            this.numRowBuffer.Location = new System.Drawing.Point(92, 47);
            this.numRowBuffer.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numRowBuffer.Name = "numRowBuffer";
            this.numRowBuffer.Size = new System.Drawing.Size(45, 20);
            this.numRowBuffer.TabIndex = 44;
            // 
            // numTickerBuffer
            // 
            this.numTickerBuffer.Location = new System.Drawing.Point(92, 73);
            this.numTickerBuffer.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numTickerBuffer.Name = "numTickerBuffer";
            this.numTickerBuffer.Size = new System.Drawing.Size(45, 20);
            this.numTickerBuffer.TabIndex = 45;
            this.numTickerBuffer.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numRefreshInterval
            // 
            this.numRefreshInterval.Location = new System.Drawing.Point(366, 14);
            this.numRefreshInterval.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numRefreshInterval.Name = "numRefreshInterval";
            this.numRefreshInterval.Size = new System.Drawing.Size(45, 20);
            this.numRefreshInterval.TabIndex = 46;
            this.numRefreshInterval.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // grpBuffers
            // 
            this.grpBuffers.Controls.Add(this.lblBorderBuffer);
            this.grpBuffers.Controls.Add(this.lblRowBuffer);
            this.grpBuffers.Controls.Add(this.numTickerBuffer);
            this.grpBuffers.Controls.Add(this.lblTickerBuffer);
            this.grpBuffers.Controls.Add(this.numRowBuffer);
            this.grpBuffers.Controls.Add(this.lblPx1);
            this.grpBuffers.Controls.Add(this.numBorderBuffer);
            this.grpBuffers.Controls.Add(this.lblPx2);
            this.grpBuffers.Controls.Add(this.lblPx3);
            this.grpBuffers.Location = new System.Drawing.Point(425, 87);
            this.grpBuffers.Name = "grpBuffers";
            this.grpBuffers.Size = new System.Drawing.Size(171, 105);
            this.grpBuffers.TabIndex = 47;
            this.grpBuffers.TabStop = false;
            this.grpBuffers.Text = "Spacing";
            // 
            // grpStyle
            // 
            this.grpStyle.Controls.Add(this.lblFontNameOutput);
            this.grpStyle.Controls.Add(this.btnFont);
            this.grpStyle.Controls.Add(this.lblTickerBackgroundColor);
            this.grpStyle.Controls.Add(this.lblTickerFontColor);
            this.grpStyle.Controls.Add(this.btnTickerBackgroundColor);
            this.grpStyle.Controls.Add(this.btnTickerFontColor);
            this.grpStyle.Location = new System.Drawing.Point(12, 87);
            this.grpStyle.Name = "grpStyle";
            this.grpStyle.Size = new System.Drawing.Size(242, 105);
            this.grpStyle.TabIndex = 48;
            this.grpStyle.TabStop = false;
            this.grpStyle.Text = "Style";
            // 
            // lblTickerFormatInstructions
            // 
            this.lblTickerFormatInstructions.AutoSize = true;
            this.lblTickerFormatInstructions.Location = new System.Drawing.Point(28, 225);
            this.lblTickerFormatInstructions.Name = "lblTickerFormatInstructions";
            this.lblTickerFormatInstructions.Size = new System.Drawing.Size(549, 52);
            this.lblTickerFormatInstructions.TabIndex = 49;
            this.lblTickerFormatInstructions.Text = resources.GetString("lblTickerFormatInstructions.Text");
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 417);
            this.Controls.Add(this.lblTickerFormatInstructions);
            this.Controls.Add(this.grpStyle);
            this.Controls.Add(this.grpBuffers);
            this.Controls.Add(this.numRefreshInterval);
            this.Controls.Add(this.lblTransparency2);
            this.Controls.Add(this.trackBackgroundColorTransparency);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblTransparency1);
            this.Controls.Add(this.trackFontColorTransparency);
            this.Controls.Add(this.grpAlignment);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.lblRefreshInterval);
            this.Controls.Add(this.lblRows);
            this.Controls.Add(this.txtRows);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.txtScreenLocationY);
            this.Controls.Add(this.txtScreenLocationX);
            this.Controls.Add(this.lblScreenLocation);
            this.Controls.Add(this.chkAlwaysOnTop);
            this.Controls.Add(this.txtCurrencySymbol);
            this.Controls.Add(this.lblCurrencySymbol);
            this.Controls.Add(this.txtCurrency);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.btnSettingsCancel);
            this.Controls.Add(this.btnSettingsOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SimpleTicker Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.grpAlignment.ResumeLayout(false);
            this.grpAlignment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackFontColorTransparency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBackgroundColorTransparency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBorderBuffer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRowBuffer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTickerBuffer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRefreshInterval)).EndInit();
            this.grpBuffers.ResumeLayout(false);
            this.grpBuffers.PerformLayout();
            this.grpStyle.ResumeLayout(false);
            this.grpStyle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSettingsOK;
        private System.Windows.Forms.Button btnSettingsCancel;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.TextBox txtCurrency;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox txtCurrencySymbol;
        private System.Windows.Forms.Label lblCurrencySymbol;
        private System.Windows.Forms.CheckBox chkAlwaysOnTop;
        private System.Windows.Forms.Label lblBorderBuffer;
        private System.Windows.Forms.Label lblRowBuffer;
        private System.Windows.Forms.Label lblTickerBuffer;
        private System.Windows.Forms.Label lblPx1;
        private System.Windows.Forms.Label lblPx2;
        private System.Windows.Forms.Label lblPx3;
        private System.Windows.Forms.Label lblScreenLocation;
        private System.Windows.Forms.TextBox txtScreenLocationX;
        private System.Windows.Forms.TextBox txtScreenLocationY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Label lblRefreshInterval;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.GroupBox grpAlignment;
        private System.Windows.Forms.RadioButton radFreeForm;
        private System.Windows.Forms.RadioButton radTable;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Label lblFontNameOutput;
        private System.Windows.Forms.ColorDialog colorTickerBackground;
        private System.Windows.Forms.Label lblTickerBackgroundColor;
        private System.Windows.Forms.Label lblTickerFontColor;
        private System.Windows.Forms.Button btnTickerBackgroundColor;
        private System.Windows.Forms.Button btnTickerFontColor;
        private System.Windows.Forms.ColorDialog colorTickerFont;
        private System.Windows.Forms.TrackBar trackFontColorTransparency;
        private System.Windows.Forms.Label lblTransparency1;
        private System.Windows.Forms.TrackBar trackBackgroundColorTransparency;
        private System.Windows.Forms.Label lblTransparency2;
        private System.Windows.Forms.CheckBox chkScrollingMode;
        private System.Windows.Forms.Label lblPx4;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.NumericUpDown numBorderBuffer;
        private System.Windows.Forms.NumericUpDown numRowBuffer;
        private System.Windows.Forms.NumericUpDown numTickerBuffer;
        private System.Windows.Forms.NumericUpDown numRefreshInterval;
        private System.Windows.Forms.GroupBox grpBuffers;
        private System.Windows.Forms.GroupBox grpStyle;
        private System.Windows.Forms.Label lblTickerFormatInstructions;
    }
}