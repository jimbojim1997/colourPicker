namespace colourPicker
{
    partial class FrmHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistory));
            this.btnCpLastHex = new System.Windows.Forms.Button();
            this.btnCpLastRGB = new System.Windows.Forms.Button();
            this.tbLastHex = new System.Windows.Forms.TextBox();
            this.lblLastHex = new System.Windows.Forms.Label();
            this.tbLastRGB = new System.Windows.Forms.TextBox();
            this.lblLastRGB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCpLastHex
            // 
            this.btnCpLastHex.Location = new System.Drawing.Point(132, 31);
            this.btnCpLastHex.Name = "btnCpLastHex";
            this.btnCpLastHex.Size = new System.Drawing.Size(61, 21);
            this.btnCpLastHex.TabIndex = 12;
            this.btnCpLastHex.Text = "Copy";
            this.btnCpLastHex.UseVisualStyleBackColor = true;
            this.btnCpLastHex.Click += new System.EventHandler(this.btnCpLastHex_Click);
            // 
            // btnCpLastRGB
            // 
            this.btnCpLastRGB.Location = new System.Drawing.Point(132, 5);
            this.btnCpLastRGB.Name = "btnCpLastRGB";
            this.btnCpLastRGB.Size = new System.Drawing.Size(61, 21);
            this.btnCpLastRGB.TabIndex = 11;
            this.btnCpLastRGB.Text = "Copy";
            this.btnCpLastRGB.UseVisualStyleBackColor = true;
            this.btnCpLastRGB.Click += new System.EventHandler(this.btnCpLastRGB_Click);
            // 
            // tbLastHex
            // 
            this.tbLastHex.Location = new System.Drawing.Point(48, 32);
            this.tbLastHex.Name = "tbLastHex";
            this.tbLastHex.ReadOnly = true;
            this.tbLastHex.Size = new System.Drawing.Size(78, 20);
            this.tbLastHex.TabIndex = 10;
            this.tbLastHex.Text = "#000000";
            // 
            // lblLastHex
            // 
            this.lblLastHex.AutoSize = true;
            this.lblLastHex.Location = new System.Drawing.Point(12, 35);
            this.lblLastHex.Name = "lblLastHex";
            this.lblLastHex.Size = new System.Drawing.Size(29, 13);
            this.lblLastHex.TabIndex = 9;
            this.lblLastHex.Text = "HEX";
            // 
            // tbLastRGB
            // 
            this.tbLastRGB.Location = new System.Drawing.Point(48, 6);
            this.tbLastRGB.Name = "tbLastRGB";
            this.tbLastRGB.ReadOnly = true;
            this.tbLastRGB.Size = new System.Drawing.Size(78, 20);
            this.tbLastRGB.TabIndex = 8;
            this.tbLastRGB.Text = "000, 000, 000";
            // 
            // lblLastRGB
            // 
            this.lblLastRGB.AutoSize = true;
            this.lblLastRGB.Location = new System.Drawing.Point(12, 9);
            this.lblLastRGB.Name = "lblLastRGB";
            this.lblLastRGB.Size = new System.Drawing.Size(30, 13);
            this.lblLastRGB.TabIndex = 7;
            this.lblLastRGB.Text = "RGB";
            // 
            // FrmHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 60);
            this.Controls.Add(this.btnCpLastHex);
            this.Controls.Add(this.btnCpLastRGB);
            this.Controls.Add(this.tbLastHex);
            this.Controls.Add(this.lblLastHex);
            this.Controls.Add(this.tbLastRGB);
            this.Controls.Add(this.lblLastRGB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHistory";
            this.Text = "Colour History";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHistory_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCpLastHex;
        private System.Windows.Forms.Button btnCpLastRGB;
        private System.Windows.Forms.TextBox tbLastHex;
        private System.Windows.Forms.Label lblLastHex;
        private System.Windows.Forms.TextBox tbLastRGB;
        private System.Windows.Forms.Label lblLastRGB;
    }
}