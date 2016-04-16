﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace colourPicker
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            Opacity = 0;
        }

        
        
        
        
        #region events
        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
            else
            {
                Application.Exit();
            }
        }

        private void niPicker_DoubleClick(object sender, EventArgs e)
        {
            Bitmap screenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                                           Screen.PrimaryScreen.Bounds.Height);
            Graphics g = Graphics.FromImage(screenshot);
            g.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
                             Screen.PrimaryScreen.Bounds.Y,
                             0,
                             0,
                             Screen.PrimaryScreen.Bounds.Size,
                             CopyPixelOperation.SourceCopy);
            frmPicker picker = new frmPicker(screenshot);
            if (picker.ShowDialog() == DialogResult.OK)
            {
                Color c = picker.pixelColor;

                niPicker.BalloonTipTitle = "Pixel Colour";
                niPicker.BalloonTipText = String.Format("RGB: {0}, {1}, {2}\nHEX: {3}", c.R.ToString().PadLeft(3), c.G.ToString().PadLeft(3), c.B.ToString().PadLeft(3), ColorTranslator.ToHtml(c));
                niPicker.ShowBalloonTip(5000);

                Clipboard.SetText(ColorTranslator.ToHtml(c));

                tbLastRGB.Text = String.Format("{0}, {1}, {2}", c.R.ToString().PadLeft(3), c.G.ToString().PadLeft(3), c.B.ToString().PadLeft(3));
                tbLastHex.Text = ColorTranslator.ToHtml(c);
            }
        }

        private void tHide_Tick(object sender, EventArgs e)
        {
            Timer t = (Timer)sender;
            t.Enabled = false;
            this.Hide();
            this.Opacity = 1;
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCpLastRGB_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbLastRGB.Text);
        }

        private void btnCpLastHex_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbLastHex.Text);
        }
        #endregion
    }
}
