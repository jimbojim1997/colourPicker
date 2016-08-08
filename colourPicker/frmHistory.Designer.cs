namespace colorPicker
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
            this.dgvColors = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RGB = new System.Windows.Forms.DataGridViewButtonColumn();
            this.HEX = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColors)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvColors
            // 
            this.dgvColors.AllowUserToAddRows = false;
            this.dgvColors.AllowUserToDeleteRows = false;
            this.dgvColors.AllowUserToResizeColumns = false;
            this.dgvColors.AllowUserToResizeRows = false;
            this.dgvColors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.RGB,
            this.HEX});
            this.dgvColors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvColors.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvColors.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvColors.Location = new System.Drawing.Point(0, 0);
            this.dgvColors.MultiSelect = false;
            this.dgvColors.Name = "dgvColors";
            this.dgvColors.ReadOnly = true;
            this.dgvColors.RowHeadersVisible = false;
            this.dgvColors.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvColors.Size = new System.Drawing.Size(193, 44);
            this.dgvColors.TabIndex = 0;
            this.dgvColors.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvColors_CellDoubleClick);
            // 
            // Index
            // 
            this.Index.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Index.HeaderText = "";
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Index.Width = 30;
            // 
            // RGB
            // 
            this.RGB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.RGB.FillWeight = 104.1916F;
            this.RGB.HeaderText = "RGB";
            this.RGB.Name = "RGB";
            this.RGB.ReadOnly = true;
            this.RGB.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RGB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.RGB.Width = 80;
            // 
            // HEX
            // 
            this.HEX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.HEX.FillWeight = 95.80838F;
            this.HEX.HeaderText = "HEX";
            this.HEX.Name = "HEX";
            this.HEX.ReadOnly = true;
            this.HEX.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.HEX.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.HEX.Width = 80;
            // 
            // FrmHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 44);
            this.Controls.Add(this.dgvColors);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(209, 10000);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(209, 38);
            this.Name = "FrmHistory";
            this.ShowInTaskbar = false;
            this.Text = "History";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHistory_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvColors;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewButtonColumn RGB;
        private System.Windows.Forms.DataGridViewButtonColumn HEX;
    }
}