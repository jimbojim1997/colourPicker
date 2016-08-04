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
    public partial class FrmPicker : Form
    {
        private Bitmap screenshot;
        private Color tintColor;
        private Action<Color> closingAction;

        public FrmPicker(Bitmap screenshot, Color tintColor, Action<Color> closingAction)
        {
            this.screenshot = screenshot;
            this.tintColor = tintColor;
            this.closingAction = closingAction;
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
                closingAction(default(Color));
            }
        }

        private void pbScreen_MouseDown(object sender, MouseEventArgs e)
        {
            closingAction(screenshot.GetPixel(e.X, e.Y));
        }
    }
}
