namespace SimpleTickerWindowsForms
{
    partial class SimpleTickerView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimpleTickerView));
            this.APIPollingTimer = new System.Windows.Forms.Timer(this.components);
            this.UIRefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.ScrollingTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // APIPollingTimer
            // 
            this.APIPollingTimer.Enabled = true;
            this.APIPollingTimer.Interval = 300000;
            this.APIPollingTimer.Tick += new System.EventHandler(this.APIPollingTimer_Tick);
            // 
            // UIRefreshTimer
            // 
            this.UIRefreshTimer.Enabled = true;
            this.UIRefreshTimer.Interval = 10000;
            this.UIRefreshTimer.Tick += new System.EventHandler(this.UIRefreshTimer_Tick);
            // 
            // ScrollingTimer
            // 
            this.ScrollingTimer.Interval = 45;
            this.ScrollingTimer.Tick += new System.EventHandler(this.ScrollingTimer_Tick);
            // 
            // SimpleTickerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(306, 25);
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(600, 800);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SimpleTickerView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SimpleTicker";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SimpleTickerView_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer APIPollingTimer;
        private System.Windows.Forms.Timer UIRefreshTimer;
        private System.Windows.Forms.Timer ScrollingTimer;
    }
}

