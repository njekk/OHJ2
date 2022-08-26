using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vk3kt4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbNum1_Leave(object sender, EventArgs e)
        {
            try
            {
                int.Parse(tbNum1.Text);
                tssLabel.Text = "OK";
            }
            catch (Exception)
            {
                tbNum1.Focus();
                tssLabel.Text = "Virheellinen syöte";
            }
        }

        private void tbNum2_Leave(object sender, EventArgs e)
        {
            try
            {
                int.Parse(tbNum2.Text);
                tssLabel.Text = "OK";
            }
            catch (Exception)
            {
                tbNum2.Focus();
                tssLabel.Text = "Virheellinen syöte";
            }
        }
    }
}
