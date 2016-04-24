using System;
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
    public partial class FrmPicker : Form
    {
        private Bitmap screenshot;
        private Color tintColor;
        public Color pixelColor;
        


        public FrmPicker(Bitmap screenshot, Color tintColor)
        {
            this.screenshot = screenshot;
            this.tintColor = tintColor;
            InitializeComponent();
        }

        private void frmPicker_Load(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(screenshot);
            g.FillRectangle(new SolidBrush(tintColor), 0, 0, screenshot.Width, screenshot.Height);
            g.Flush();

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
