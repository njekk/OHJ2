using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vk2kt2
{
    public partial class FrmPosChance : Form
    {
        public FrmPosChance()
        {
            InitializeComponent();
        }

        private void FrmPosChance_MouseClick(object sender, MouseEventArgs e)
        {
            

        }

        private void btnChance_Click(object sender, EventArgs e)
        {
            int x, y;
            x = int.Parse(tbX.Text);
            y = int.Parse(tbY.Text);
            btnChance.Location = new Point(x, y);
        }

        private void tbX_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbX_KeyPress(object sender, KeyPressEventArgs e)
        {
            char inp =e.KeyChar;
            if (!char.IsDigit(inp) && inp !=8 && inp != 48)
            {
                e.Handled = true;
            }
        }

        private void tbY_KeyPress(object sender, KeyPressEventArgs e)
        {
            char inp = e.KeyChar;
            if (!char.IsDigit(inp) && inp != 8 && inp != 48)
            {
                e.Handled = true;
            }

        }

        private void tbX_Leave(object sender, EventArgs e)
        {
            if (tbX.Text== "")
            {
                tbX.Text = "0";
            }
        }

        private void tbY_Leave(object sender, EventArgs e)
        {
            if (tbY.Text == "")
            {
                tbY.Text = "0";
            }
        }
    }
}
