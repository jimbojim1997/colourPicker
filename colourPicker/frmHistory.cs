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

        public void UpdateColor(Color color)
        {
            DataGridViewRow row = new DataGridViewRow();

            //Index
            {
                DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                cell.Value = dgvColors.Rows.Count + 1;
                row.Cells.Add(cell);
            }

            //RGB
            {
                DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                cell.Value = String.Format("{0}, {1}, {2}",
                                           color.R.ToString().PadLeft(3, '0'),
                                           color.G.ToString().PadLeft(3, '0'),
                                           color.B.ToString().PadLeft(3, '0'));
                row.Cells.Add(cell);
            }

            //HEX
            {
                DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                cell.Value = ColorTranslator.ToHtml(color);
                row.Cells.Add(cell);
            }

            dgvColors.Rows.Insert(0, row);
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

        private void dgvColors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView grid = (DataGridView)sender;
            if (grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                DataGridViewCell cell = grid.Rows[e.RowIndex].Cells[e.ColumnIndex];
                Clipboard.SetText(cell.Value.ToString());
            }
        }
    }
}
