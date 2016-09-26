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
        private Action<Color> closingAction;

        public FrmPicker(Screen screen, Action<Color> closingAction)
        {
            InitializeComponent();

            this.closingAction = closingAction;

            Rectangle bounds = screen.Bounds;
            Bitmap screenshot = new Bitmap(bounds.Width, bounds.Height);

            Graphics g = Graphics.FromImage(screenshot);
            g.CopyFromScreen(bounds.Left, bounds.Top, 0, 0, bounds.Size, CopyPixelOperation.SourceCopy);
            g.Flush();
            pbScreen.Image = screenshot;

            this.SetDesktopLocation(bounds.Left, bounds.Top);
        }

        private void frmPicker_Load(object sender, EventArgs e)
        {

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
            Color pixel = ((Bitmap)pbScreen.Image).GetPixel(e.X, e.Y);
            closingAction(pixel);
        }
    }
}
