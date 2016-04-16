namespace colourPicker
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.niPicker = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsNotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tHide = new System.Windows.Forms.Timer(this.components);
            this.lblLastRGB = new System.Windows.Forms.Label();
            this.tbLastRGB = new System.Windows.Forms.TextBox();
            this.tbLastHex = new System.Windows.Forms.TextBox();
            this.lblLastHex = new System.Windows.Forms.Label();
            this.btnCpLastRGB = new System.Windows.Forms.Button();
            this.btnCpLastHex = new System.Windows.Forms.Button();
            this.cmsNotifyIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // niPicker
            // 
            this.niPicker.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.niPicker.ContextMenuStrip = this.cmsNotifyIcon;
            this.niPicker.Icon = ((System.Drawing.Icon)(resources.GetObject("niPicker.Icon")));
            this.niPicker.Text = "Colour Picker";
            this.niPicker.Visible = true;
            this.niPicker.DoubleClick += new System.EventHandler(this.niPicker_DoubleClick);
            // 
            // cmsNotifyIcon
            // 
            this.cmsNotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.cmsNotifyIcon.Name = "cmsNotifyIcon";
            this.cmsNotifyIcon.Size = new System.Drawing.Size(117, 48);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tHide
            // 
            this.tHide.Enabled = true;
            this.tHide.Interval = 1;
            this.tHide.Tick += new System.EventHandler(this.tHide_Tick);
            // 
            // lblLastRGB
            // 
            this.lblLastRGB.AutoSize = true;
            this.lblLastRGB.Location = new System.Drawing.Point(12, 9);
            this.lblLastRGB.Name = "lblLastRGB";
            this.lblLastRGB.Size = new System.Drawing.Size(30, 13);
            this.lblLastRGB.TabIndex = 1;
            this.lblLastRGB.Text = "RGB";
            // 
            // tbLastRGB
            // 
            this.tbLastRGB.Location = new System.Drawing.Point(48, 6);
            this.tbLastRGB.Name = "tbLastRGB";
            this.tbLastRGB.ReadOnly = true;
            this.tbLastRGB.Size = new System.Drawing.Size(78, 20);
            this.tbLastRGB.TabIndex = 2;
            this.tbLastRGB.Text = "000, 000, 000";
            // 
            // tbLastHex
            // 
            this.tbLastHex.Location = new System.Drawing.Point(48, 32);
            this.tbLastHex.Name = "tbLastHex";
            this.tbLastHex.ReadOnly = true;
            this.tbLastHex.Size = new System.Drawing.Size(78, 20);
            this.tbLastHex.TabIndex = 4;
            this.tbLastHex.Text = "#000000";
            // 
            // lblLastHex
            // 
            this.lblLastHex.AutoSize = true;
            this.lblLastHex.Location = new System.Drawing.Point(12, 35);
            this.lblLastHex.Name = "lblLastHex";
            this.lblLastHex.Size = new System.Drawing.Size(29, 13);
            this.lblLastHex.TabIndex = 3;
            this.lblLastHex.Text = "HEX";
            // 
            // btnCpLastRGB
            // 
            this.btnCpLastRGB.Location = new System.Drawing.Point(132, 5);
            this.btnCpLastRGB.Name = "btnCpLastRGB";
            this.btnCpLastRGB.Size = new System.Drawing.Size(61, 21);
            this.btnCpLastRGB.TabIndex = 5;
            this.btnCpLastRGB.Text = "Copy";
            this.btnCpLastRGB.UseVisualStyleBackColor = true;
            this.btnCpLastRGB.Click += new System.EventHandler(this.btnCpLastRGB_Click);
            // 
            // btnCpLastHex
            // 
            this.btnCpLastHex.Location = new System.Drawing.Point(132, 31);
            this.btnCpLastHex.Name = "btnCpLastHex";
            this.btnCpLastHex.Size = new System.Drawing.Size(61, 21);
            this.btnCpLastHex.TabIndex = 6;
            this.btnCpLastHex.Text = "Copy";
            this.btnCpLastHex.UseVisualStyleBackColor = true;
            this.btnCpLastHex.Click += new System.EventHandler(this.btnCpLastHex_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 340);
            this.Controls.Add(this.btnCpLastHex);
            this.Controls.Add(this.btnCpLastRGB);
            this.Controls.Add(this.tbLastHex);
            this.Controls.Add(this.lblLastHex);
            this.Controls.Add(this.tbLastRGB);
            this.Controls.Add(this.lblLastRGB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Opacity = 0D;
            this.Text = "Colour Picker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.cmsNotifyIcon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tHide;
        private System.Windows.Forms.ContextMenuStrip cmsNotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon niPicker;
        private System.Windows.Forms.Label lblLastRGB;
        private System.Windows.Forms.TextBox tbLastRGB;
        private System.Windows.Forms.TextBox tbLastHex;
        private System.Windows.Forms.Label lblLastHex;
        private System.Windows.Forms.Button btnCpLastRGB;
        private System.Windows.Forms.Button btnCpLastHex;
    }
}

