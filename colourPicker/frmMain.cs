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
            
            frmHistory = new FrmHistory();
            frmPickers = new List<FrmPicker>();
        }

        private void ShowPickers()
        {
            foreach(Screen screen in Screen.AllScreens)
            {
                FrmPicker picker = new FrmPicker(screen, PickerAction);
                picker.Show();
                frmPickers.Add(picker);
            }
        }

        private void PickerAction(Color color)
        {
            foreach(FrmPicker frmPicker in frmPickers)
            {
                frmPicker.Close();
            }
            frmPickers.Clear();

            if (color != default(Color))
            {
                ShowBalloonColorText(color);
                frmHistory.UpdateColor(color);
                Clipboard.SetText(ColorTranslator.ToHtml(color));
            }

        }

        private void ShowBalloonColorText(Color color)
        {
            niPicker.BalloonTipTitle = "Pixel color";
            niPicker.BalloonTipText = String.Format("RGB: {0}, {1}, {2}\nHEX: {3}", color.R.ToString().PadLeft(3, '0'), color.G.ToString().PadLeft(3, '0'), color.B.ToString().PadLeft(3, '0'), ColorTranslator.ToHtml(color));
            niPicker.ShowBalloonTip(8000);
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
        #endregion
    }
}
