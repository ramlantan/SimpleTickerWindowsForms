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
            this.numBorderBuffer = new System.Windows.Forms.NumericUpDown();
            this.numRowBuffer = new System.Windows.Forms.NumericUpDown();
            this.numTickerBuffer = new System.Windows.Forms.NumericUpDown();
            this.grpBuffers = new System.Windows.Forms.GroupBox();
            this.grpStyle = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Basic = new System.Windows.Forms.TabPage();
            this.Appearance = new System.Windows.Forms.TabPage();
            this.lblTickerFormatInstructions = new System.Windows.Forms.Label();
            this.lblRows = new System.Windows.Forms.Label();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtCurrencySymbol = new System.Windows.Forms.TextBox();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.numRefreshInterval = new System.Windows.Forms.NumericUpDown();
            this.txtCurrency = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblCurrencySymbol = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblRefreshInterval = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpAlignment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBorderBuffer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRowBuffer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTickerBuffer)).BeginInit();
            this.grpBuffers.SuspendLayout();
            this.grpStyle.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Basic.SuspendLayout();
            this.Appearance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRefreshInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSettingsOK
            // 
            this.btnSettingsOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSettingsOK.Location = new System.Drawing.Point(593, 296);
            this.btnSettingsOK.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSettingsOK.Name = "btnSettingsOK";
            this.btnSettingsOK.Size = new System.Drawing.Size(99, 27);
            this.btnSettingsOK.TabIndex = 0;
            this.btnSettingsOK.Text = "OK";
            this.btnSettingsOK.UseVisualStyleBackColor = true;
            this.btnSettingsOK.Click += new System.EventHandler(this.BtnSettingsOK_Click);
            // 
            // btnSettingsCancel
            // 
            this.btnSettingsCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSettingsCancel.Location = new System.Drawing.Point(698, 296);
            this.btnSettingsCancel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSettingsCancel.Name = "btnSettingsCancel";
            this.btnSettingsCancel.Size = new System.Drawing.Size(99, 27);
            this.btnSettingsCancel.TabIndex = 1;
            this.btnSettingsCancel.Text = "Cancel";
            this.btnSettingsCancel.UseVisualStyleBackColor = true;
            this.btnSettingsCancel.Click += new System.EventHandler(this.BtnSettingsCancel_Click);
            // 
            // chkAlwaysOnTop
            // 
            this.chkAlwaysOnTop.AutoSize = true;
            this.chkAlwaysOnTop.Checked = true;
            this.chkAlwaysOnTop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAlwaysOnTop.Location = new System.Drawing.Point(671, 144);
            this.chkAlwaysOnTop.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.chkAlwaysOnTop.Name = "chkAlwaysOnTop";
            this.chkAlwaysOnTop.Size = new System.Drawing.Size(110, 20);
            this.chkAlwaysOnTop.TabIndex = 12;
            this.chkAlwaysOnTop.Text = "Always on top";
            this.chkAlwaysOnTop.UseVisualStyleBackColor = true;
            // 
            // lblBorderBuffer
            // 
            this.lblBorderBuffer.AutoSize = true;
            this.lblBorderBuffer.Location = new System.Drawing.Point(23, 27);
            this.lblBorderBuffer.Name = "lblBorderBuffer";
            this.lblBorderBuffer.Size = new System.Drawing.Size(86, 16);
            this.lblBorderBuffer.TabIndex = 13;
            this.lblBorderBuffer.Text = "Border Buffer";
            // 
            // lblRowBuffer
            // 
            this.lblRowBuffer.AutoSize = true;
            this.lblRowBuffer.Location = new System.Drawing.Point(35, 59);
            this.lblRowBuffer.Name = "lblRowBuffer";
            this.lblRowBuffer.Size = new System.Drawing.Size(72, 16);
            this.lblRowBuffer.TabIndex = 15;
            this.lblRowBuffer.Text = "Row Buffer";
            // 
            // lblTickerBuffer
            // 
            this.lblTickerBuffer.AutoSize = true;
            this.lblTickerBuffer.Location = new System.Drawing.Point(24, 91);
            this.lblTickerBuffer.Name = "lblTickerBuffer";
            this.lblTickerBuffer.Size = new System.Drawing.Size(83, 16);
            this.lblTickerBuffer.TabIndex = 17;
            this.lblTickerBuffer.Text = "Ticker Buffer";
            // 
            // lblPx1
            // 
            this.lblPx1.AutoSize = true;
            this.lblPx1.Location = new System.Drawing.Point(187, 27);
            this.lblPx1.Name = "lblPx1";
            this.lblPx1.Size = new System.Drawing.Size(22, 16);
            this.lblPx1.TabIndex = 19;
            this.lblPx1.Text = "px";
            // 
            // lblPx2
            // 
            this.lblPx2.AutoSize = true;
            this.lblPx2.Location = new System.Drawing.Point(187, 59);
            this.lblPx2.Name = "lblPx2";
            this.lblPx2.Size = new System.Drawing.Size(22, 16);
            this.lblPx2.TabIndex = 20;
            this.lblPx2.Text = "px";
            // 
            // lblPx3
            // 
            this.lblPx3.AutoSize = true;
            this.lblPx3.Location = new System.Drawing.Point(187, 91);
            this.lblPx3.Name = "lblPx3";
            this.lblPx3.Size = new System.Drawing.Size(22, 16);
            this.lblPx3.TabIndex = 21;
            this.lblPx3.Text = "px";
            // 
            // lblScreenLocation
            // 
            this.lblScreenLocation.AutoSize = true;
            this.lblScreenLocation.Location = new System.Drawing.Point(8, 272);
            this.lblScreenLocation.Name = "lblScreenLocation";
            this.lblScreenLocation.Size = new System.Drawing.Size(174, 16);
            this.lblScreenLocation.TabIndex = 22;
            this.lblScreenLocation.Text = "Screen Location (automatic)";
            // 
            // txtScreenLocationX
            // 
            this.txtScreenLocationX.Location = new System.Drawing.Point(35, 293);
            this.txtScreenLocationX.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtScreenLocationX.Name = "txtScreenLocationX";
            this.txtScreenLocationX.Size = new System.Drawing.Size(52, 22);
            this.txtScreenLocationX.TabIndex = 23;
            this.txtScreenLocationX.Text = "0";
            // 
            // txtScreenLocationY
            // 
            this.txtScreenLocationY.Location = new System.Drawing.Point(123, 293);
            this.txtScreenLocationY.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtScreenLocationY.Name = "txtScreenLocationY";
            this.txtScreenLocationY.Size = new System.Drawing.Size(52, 22);
            this.txtScreenLocationY.TabIndex = 24;
            this.txtScreenLocationY.Text = "0";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(8, 297);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(16, 16);
            this.lblX.TabIndex = 25;
            this.lblX.Text = "X";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(96, 297);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(17, 16);
            this.lblY.TabIndex = 26;
            this.lblY.Text = "Y";
            // 
            // grpAlignment
            // 
            this.grpAlignment.Controls.Add(this.lblPx4);
            this.grpAlignment.Controls.Add(this.lblWidth);
            this.grpAlignment.Controls.Add(this.numWidth);
            this.grpAlignment.Controls.Add(this.chkScrollingMode);
            this.grpAlignment.Controls.Add(this.radFreeForm);
            this.grpAlignment.Controls.Add(this.radTable);
            this.grpAlignment.Location = new System.Drawing.Point(339, 9);
            this.grpAlignment.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grpAlignment.Name = "grpAlignment";
            this.grpAlignment.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grpAlignment.Size = new System.Drawing.Size(211, 130);
            this.grpAlignment.TabIndex = 32;
            this.grpAlignment.TabStop = false;
            this.grpAlignment.Text = "Ticker Alignment";
            // 
            // lblPx4
            // 
            this.lblPx4.AutoSize = true;
            this.lblPx4.Location = new System.Drawing.Point(173, 96);
            this.lblPx4.Name = "lblPx4";
            this.lblPx4.Size = new System.Drawing.Size(22, 16);
            this.lblPx4.TabIndex = 43;
            this.lblPx4.Text = "px";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(45, 99);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(42, 16);
            this.lblWidth.TabIndex = 45;
            this.lblWidth.Text = "Width";
            // 
            // numWidth
            // 
            this.numWidth.Location = new System.Drawing.Point(99, 91);
            this.numWidth.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.numWidth.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(65, 22);
            this.numWidth.TabIndex = 44;
            // 
            // chkScrollingMode
            // 
            this.chkScrollingMode.AutoSize = true;
            this.chkScrollingMode.Checked = true;
            this.chkScrollingMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkScrollingMode.Location = new System.Drawing.Point(49, 70);
            this.chkScrollingMode.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.chkScrollingMode.Name = "chkScrollingMode";
            this.chkScrollingMode.Size = new System.Drawing.Size(79, 20);
            this.chkScrollingMode.TabIndex = 43;
            this.chkScrollingMode.Text = "Scrolling";
            this.chkScrollingMode.UseVisualStyleBackColor = true;
            this.chkScrollingMode.Click += new System.EventHandler(this.ChkScrollingMode_Click);
            // 
            // radFreeForm
            // 
            this.radFreeForm.AutoSize = true;
            this.radFreeForm.Location = new System.Drawing.Point(23, 46);
            this.radFreeForm.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.radFreeForm.Name = "radFreeForm";
            this.radFreeForm.Size = new System.Drawing.Size(83, 20);
            this.radFreeForm.TabIndex = 1;
            this.radFreeForm.Text = "Free form";
            this.radFreeForm.UseVisualStyleBackColor = true;
            this.radFreeForm.CheckedChanged += new System.EventHandler(this.RadFreeForm_CheckedChanged);
            // 
            // radTable
            // 
            this.radTable.AutoSize = true;
            this.radTable.Checked = true;
            this.radTable.Location = new System.Drawing.Point(23, 23);
            this.radTable.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.radTable.Name = "radTable";
            this.radTable.Size = new System.Drawing.Size(105, 20);
            this.radTable.TabIndex = 0;
            this.radTable.TabStop = true;
            this.radTable.Text = "Aligned table";
            this.radTable.UseVisualStyleBackColor = true;
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(25, 23);
            this.btnFont.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(81, 27);
            this.btnFont.TabIndex = 33;
            this.btnFont.Text = "Font...";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.BtnFont_Click);
            // 
            // lblFontNameOutput
            // 
            this.lblFontNameOutput.AutoSize = true;
            this.lblFontNameOutput.Location = new System.Drawing.Point(115, 27);
            this.lblFontNameOutput.Name = "lblFontNameOutput";
            this.lblFontNameOutput.Size = new System.Drawing.Size(71, 16);
            this.lblFontNameOutput.TabIndex = 34;
            this.lblFontNameOutput.Text = "FontName";
            // 
            // lblTickerBackgroundColor
            // 
            this.lblTickerBackgroundColor.AutoSize = true;
            this.lblTickerBackgroundColor.Location = new System.Drawing.Point(21, 62);
            this.lblTickerBackgroundColor.Name = "lblTickerBackgroundColor";
            this.lblTickerBackgroundColor.Size = new System.Drawing.Size(122, 16);
            this.lblTickerBackgroundColor.TabIndex = 35;
            this.lblTickerBackgroundColor.Text = "Ticker Background";
            // 
            // lblTickerFontColor
            // 
            this.lblTickerFontColor.AutoSize = true;
            this.lblTickerFontColor.Location = new System.Drawing.Point(21, 91);
            this.lblTickerFontColor.Name = "lblTickerFontColor";
            this.lblTickerFontColor.Size = new System.Drawing.Size(69, 16);
            this.lblTickerFontColor.TabIndex = 36;
            this.lblTickerFontColor.Text = "Font Color";
            // 
            // btnTickerBackgroundColor
            // 
            this.btnTickerBackgroundColor.BackColor = System.Drawing.Color.Black;
            this.btnTickerBackgroundColor.Location = new System.Drawing.Point(179, 55);
            this.btnTickerBackgroundColor.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnTickerBackgroundColor.Name = "btnTickerBackgroundColor";
            this.btnTickerBackgroundColor.Size = new System.Drawing.Size(32, 27);
            this.btnTickerBackgroundColor.TabIndex = 37;
            this.btnTickerBackgroundColor.UseVisualStyleBackColor = false;
            this.btnTickerBackgroundColor.Click += new System.EventHandler(this.BtnTickerBackgroundColor_Click);
            // 
            // btnTickerFontColor
            // 
            this.btnTickerFontColor.BackColor = System.Drawing.Color.White;
            this.btnTickerFontColor.Location = new System.Drawing.Point(179, 86);
            this.btnTickerFontColor.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnTickerFontColor.Name = "btnTickerFontColor";
            this.btnTickerFontColor.Size = new System.Drawing.Size(32, 27);
            this.btnTickerFontColor.TabIndex = 38;
            this.btnTickerFontColor.UseVisualStyleBackColor = false;
            this.btnTickerFontColor.Click += new System.EventHandler(this.BtnTickerFontColor_Click);
            // 
            // numBorderBuffer
            // 
            this.numBorderBuffer.Location = new System.Drawing.Point(123, 23);
            this.numBorderBuffer.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.numBorderBuffer.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numBorderBuffer.Name = "numBorderBuffer";
            this.numBorderBuffer.Size = new System.Drawing.Size(59, 22);
            this.numBorderBuffer.TabIndex = 43;
            // 
            // numRowBuffer
            // 
            this.numRowBuffer.Location = new System.Drawing.Point(123, 58);
            this.numRowBuffer.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.numRowBuffer.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numRowBuffer.Name = "numRowBuffer";
            this.numRowBuffer.Size = new System.Drawing.Size(59, 22);
            this.numRowBuffer.TabIndex = 44;
            // 
            // numTickerBuffer
            // 
            this.numTickerBuffer.Location = new System.Drawing.Point(123, 90);
            this.numTickerBuffer.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.numTickerBuffer.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numTickerBuffer.Name = "numTickerBuffer";
            this.numTickerBuffer.Size = new System.Drawing.Size(59, 22);
            this.numTickerBuffer.TabIndex = 45;
            this.numTickerBuffer.Value = new decimal(new int[] {
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
            this.grpBuffers.Location = new System.Drawing.Point(559, 9);
            this.grpBuffers.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grpBuffers.Name = "grpBuffers";
            this.grpBuffers.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grpBuffers.Size = new System.Drawing.Size(227, 130);
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
            this.grpStyle.Location = new System.Drawing.Point(8, 9);
            this.grpStyle.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grpStyle.Name = "grpStyle";
            this.grpStyle.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grpStyle.Size = new System.Drawing.Size(323, 130);
            this.grpStyle.TabIndex = 48;
            this.grpStyle.TabStop = false;
            this.grpStyle.Text = "Style";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Basic);
            this.tabControl1.Controls.Add(this.Appearance);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(811, 357);
            this.tabControl1.TabIndex = 50;
            // 
            // Basic
            // 
            this.Basic.Controls.Add(this.label1);
            this.Basic.Controls.Add(this.txtCurrencySymbol);
            this.Basic.Controls.Add(this.lblCurrency);
            this.Basic.Controls.Add(this.numRefreshInterval);
            this.Basic.Controls.Add(this.txtCurrency);
            this.Basic.Controls.Add(this.linkLabel1);
            this.Basic.Controls.Add(this.lblCurrencySymbol);
            this.Basic.Controls.Add(this.lblMinutes);
            this.Basic.Controls.Add(this.lblRefreshInterval);
            this.Basic.Controls.Add(this.button1);
            this.Basic.Controls.Add(this.button2);
            this.Basic.Controls.Add(this.lblTickerFormatInstructions);
            this.Basic.Controls.Add(this.lblRows);
            this.Basic.Controls.Add(this.txtRows);
            this.Basic.Location = new System.Drawing.Point(4, 25);
            this.Basic.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Basic.Name = "Basic";
            this.Basic.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Basic.Size = new System.Drawing.Size(803, 328);
            this.Basic.TabIndex = 0;
            this.Basic.Text = "Basic";
            this.Basic.UseVisualStyleBackColor = true;
            // 
            // Appearance
            // 
            this.Appearance.Controls.Add(this.btnSettingsOK);
            this.Appearance.Controls.Add(this.grpStyle);
            this.Appearance.Controls.Add(this.btnSettingsCancel);
            this.Appearance.Controls.Add(this.grpBuffers);
            this.Appearance.Controls.Add(this.grpAlignment);
            this.Appearance.Controls.Add(this.chkAlwaysOnTop);
            this.Appearance.Controls.Add(this.lblScreenLocation);
            this.Appearance.Controls.Add(this.txtScreenLocationX);
            this.Appearance.Controls.Add(this.txtScreenLocationY);
            this.Appearance.Controls.Add(this.lblX);
            this.Appearance.Controls.Add(this.lblY);
            this.Appearance.Location = new System.Drawing.Point(4, 25);
            this.Appearance.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Appearance.Name = "Appearance";
            this.Appearance.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Appearance.Size = new System.Drawing.Size(803, 328);
            this.Appearance.TabIndex = 1;
            this.Appearance.Text = "Appearance";
            this.Appearance.UseVisualStyleBackColor = true;
            // 
            // lblTickerFormatInstructions
            // 
            this.lblTickerFormatInstructions.AutoSize = true;
            this.lblTickerFormatInstructions.BackColor = System.Drawing.Color.Ivory;
            this.lblTickerFormatInstructions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTickerFormatInstructions.Location = new System.Drawing.Point(369, 68);
            this.lblTickerFormatInstructions.Name = "lblTickerFormatInstructions";
            this.lblTickerFormatInstructions.Padding = new System.Windows.Forms.Padding(5);
            this.lblTickerFormatInstructions.Size = new System.Drawing.Size(428, 92);
            this.lblTickerFormatInstructions.TabIndex = 52;
            this.lblTickerFormatInstructions.Text = resources.GetString("lblTickerFormatInstructions.Text");
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(5, 127);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(83, 16);
            this.lblRows.TabIndex = 51;
            this.lblRows.Text = "Ticker Rows";
            // 
            // txtRows
            // 
            this.txtRows.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRows.Location = new System.Drawing.Point(8, 165);
            this.txtRows.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtRows.Multiline = true;
            this.txtRows.Name = "txtRows";
            this.txtRows.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRows.Size = new System.Drawing.Size(789, 121);
            this.txtRows.TabIndex = 50;
            this.txtRows.Text = "bitcoin=BTC,ethereum=ETH\r\nLitecoin,NEO,bitcoin-cash=bcash";
            this.txtRows.WordWrap = false;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(593, 296);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 27);
            this.button1.TabIndex = 53;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnSettingsOK_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(698, 296);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 27);
            this.button2.TabIndex = 54;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnSettingsCancel_Click);
            // 
            // txtCurrencySymbol
            // 
            this.txtCurrencySymbol.Location = new System.Drawing.Point(250, 2);
            this.txtCurrencySymbol.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtCurrencySymbol.Name = "txtCurrencySymbol";
            this.txtCurrencySymbol.Size = new System.Drawing.Size(44, 22);
            this.txtCurrencySymbol.TabIndex = 59;
            this.txtCurrencySymbol.Text = "$";
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Location = new System.Drawing.Point(6, 5);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(61, 16);
            this.lblCurrency.TabIndex = 55;
            this.lblCurrency.Text = "Currency";
            // 
            // numRefreshInterval
            // 
            this.numRefreshInterval.Location = new System.Drawing.Point(101, 47);
            this.numRefreshInterval.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.numRefreshInterval.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numRefreshInterval.Name = "numRefreshInterval";
            this.numRefreshInterval.Size = new System.Drawing.Size(59, 22);
            this.numRefreshInterval.TabIndex = 62;
            this.numRefreshInterval.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // txtCurrency
            // 
            this.txtCurrency.Location = new System.Drawing.Point(73, 2);
            this.txtCurrency.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Size = new System.Drawing.Size(55, 22);
            this.txtCurrency.TabIndex = 56;
            this.txtCurrency.Text = "USD";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Ivory;
            this.linkLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.linkLabel1.Location = new System.Drawing.Point(300, 5);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Padding = new System.Windows.Forms.Padding(5);
            this.linkLabel1.Size = new System.Drawing.Size(462, 44);
            this.linkLabel1.TabIndex = 57;
            this.linkLabel1.Text = "See https://coinmarketcap.com/api/ for valid currencies.\r\nBTC and ETH are also va" +
    "lid currencies, for displaying price in sats or gwei.";
            // 
            // lblCurrencySymbol
            // 
            this.lblCurrencySymbol.AutoSize = true;
            this.lblCurrencySymbol.Location = new System.Drawing.Point(134, 5);
            this.lblCurrencySymbol.Name = "lblCurrencySymbol";
            this.lblCurrencySymbol.Size = new System.Drawing.Size(110, 16);
            this.lblCurrencySymbol.TabIndex = 58;
            this.lblCurrencySymbol.Text = "Currency Symbol";
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Location = new System.Drawing.Point(166, 49);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(54, 16);
            this.lblMinutes.TabIndex = 61;
            this.lblMinutes.Text = "minutes";
            // 
            // lblRefreshInterval
            // 
            this.lblRefreshInterval.AutoSize = true;
            this.lblRefreshInterval.Location = new System.Drawing.Point(8, 49);
            this.lblRefreshInterval.Name = "lblRefreshInterval";
            this.lblRefreshInterval.Size = new System.Drawing.Size(87, 16);
            this.lblRefreshInterval.TabIndex = 60;
            this.lblRefreshInterval.Text = "Refresh Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 63;
            this.label1.Text = "One ticker row per line";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 354);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
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
            ((System.ComponentModel.ISupportInitialize)(this.numBorderBuffer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRowBuffer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTickerBuffer)).EndInit();
            this.grpBuffers.ResumeLayout(false);
            this.grpBuffers.PerformLayout();
            this.grpStyle.ResumeLayout(false);
            this.grpStyle.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Basic.ResumeLayout(false);
            this.Basic.PerformLayout();
            this.Appearance.ResumeLayout(false);
            this.Appearance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRefreshInterval)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSettingsOK;
        private System.Windows.Forms.Button btnSettingsCancel;
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
        private System.Windows.Forms.CheckBox chkScrollingMode;
        private System.Windows.Forms.Label lblPx4;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.NumericUpDown numBorderBuffer;
        private System.Windows.Forms.NumericUpDown numRowBuffer;
        private System.Windows.Forms.NumericUpDown numTickerBuffer;
        private System.Windows.Forms.GroupBox grpBuffers;
        private System.Windows.Forms.GroupBox grpStyle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Basic;
        private System.Windows.Forms.TextBox txtCurrencySymbol;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.NumericUpDown numRefreshInterval;
        private System.Windows.Forms.TextBox txtCurrency;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblCurrencySymbol;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblRefreshInterval;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblTickerFormatInstructions;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.TabPage Appearance;
        private System.Windows.Forms.Label label1;
    }
}