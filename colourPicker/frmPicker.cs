using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace colourPicker
{
    public partial class FrmPicker : Form
    {
        private Bitmap screenshot;
        private Graphics g;
        public Color pixelColor;
        


        public FrmPicker(Bitmap screenshot)
        {
            this.screenshot = screenshot;
            InitializeComponent();
        }

        private void frmPicker_Load(object sender, EventArgs e)
        {
            pbScreen.Image = screenshot;
        }

        private void frmPicker_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Abort;
                this.Close();
            }
        }

        private void pbScreen_MouseDown(object sender, MouseEventArgs e)
        {
            pixelColor = screenshot.GetPixel(Cursor.Position.X, Cursor.Position.Y);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
