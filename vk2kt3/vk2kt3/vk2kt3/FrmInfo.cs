using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vk2kt3
{
    public partial class FrmInfo : Form
    {
        public FrmInfo()
        {
            InitializeComponent();
        }

        private void tbPostalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            char inp = e.KeyChar;
            if (!char.IsDigit(inp) && inp != 8 && inp != 48)
            {
                e.Handled = true;
            }
        }

        private void dateTimePicker1_Leave(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Today;
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string info;
            info = tbFname.Text +","+ tbSname.Text + "," + tbPhnum.Text + "," + tbAdress.Text + "," + tbPostalCode.Text + "," + tbCity.Text + "," + dateTimePicker1.Text;
            Henkilot.Items.Add(info);
            tbFname.Clear();
            tbSname.Clear();
            tbPhnum.Clear();
            tbAdress.Clear();
            tbPostalCode.Clear();
            tbCity.Clear();
            dateTimePicker1.Value = DateTime.Today;
        }

        private void Henkilot_MouseClick(object sender, MouseEventArgs e)
        {
            int lines = Henkilot.SelectedIndex;
            string info = Henkilot.Items[lines].ToString();
            string[] words = info.Split(',');
            tbFname.Text = words[0];
            tbSname.Text = words[1];
            tbPhnum.Text = words[2];
            tbAdress.Text = words[3];
            tbPostalCode.Text = words[4];
            tbCity.Text = words[5];
            dateTimePicker1.Text = words[6];
            Henkilot.Items.RemoveAt(lines);
        }
    }
}
