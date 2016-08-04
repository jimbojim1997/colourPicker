using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace colorPicker
{
    public partial class FrmMain : Form
    {
        FrmHistory frmHistory;
        List<FrmPicker> frmPickers;


        public FrmMain()
        {
            InitializeComponent();
            Opacity = 0;
            frmHistory = new FrmHistory();
            frmPickers = new List<FrmPicker>();
        }

        private void ShowPickers()
        {
            frmPickers.Clear();
            foreach(Screen screen in Screen.AllScreens)
            {
                Rectangle bounds = screen.Bounds;
                Bitmap screenshot = new Bitmap(bounds.Width,
                                               bounds.Height);

                Graphics g = Graphics.FromImage(screenshot);
                g.CopyFromScreen(bounds.X,
                                 bounds.Y,
                                 0,
                                 0,
                                 bounds.Size,
                                 CopyPixelOperation.SourceCopy);
                FrmPicker picker = new FrmPicker(screenshot, Color.FromArgb(20, 200, 200, 200), PickerAction);
                picker.SetDesktopLocation(bounds.Left, bounds.Top);
                picker.Show();
                frmPickers.Add(picker);
            }
        }

        private void PickerAction(Color c)
        {
            foreach(FrmPicker frmPicker in frmPickers)
            {
                frmPicker.Close();
            }

            if (c != default(Color))
            {
                niPicker.BalloonTipTitle = "Pixel color";
                niPicker.BalloonTipText = String.Format("RGB: {0}, {1}, {2}\nHEX: {3}", c.R.ToString().PadLeft(3), c.G.ToString().PadLeft(3), c.B.ToString().PadLeft(3), ColorTranslator.ToHtml(c));
                niPicker.ShowBalloonTip(5000);

                Clipboard.SetText(ColorTranslator.ToHtml(c));

                frmHistory.lastRGB = String.Format("{0}, {1}, {2}", c.R.ToString().PadLeft(3), c.G.ToString().PadLeft(3), c.B.ToString().PadLeft(3));
                frmHistory.lastHex = ColorTranslator.ToHtml(c);
            }

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
            ShowPickers();
        }

        private void tHide_Tick(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer t = (System.Windows.Forms.Timer)sender;
            t.Enabled = false;
            this.Hide();
            this.Opacity = 1;
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHistory.Show();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnChangeTintColor_Click(object sender, EventArgs e)
        {
            if(cdTint.ShowDialog() == DialogResult.OK)
            {
                
            }
        }
        #endregion
    }
}
