using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace colorPicker
{
    public partial class FrmHistory : Form
    {
        public FrmHistory()
        {
            InitializeComponent();
        }

        public string lastRGB
        {
            get
            {
                return tbLastRGB.Text;
            }
            set
            {
                tbLastRGB.Text = value;
            }
        }

        public string lastHex
        {
            get
            {
                return tbLastHex.Text;
            }
            set
            {
                tbLastHex.Text = value;
            }
        }

        private void FrmHistory_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
            else
            {
                Application.Exit();
            }
        }

        private void btnCpLastRGB_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lastRGB);
        }

        private void btnCpLastHex_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lastHex);
        }
    }
}
