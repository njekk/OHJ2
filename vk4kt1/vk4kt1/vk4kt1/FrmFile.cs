using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace vk4kt1
{
    public partial class FrmFile : Form
    {
        public FrmFile()
        {
            InitializeComponent();
        }
        public List<int> numbers = new List<int>();
        public int shown=0;

        private void tsmInput_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int i;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    for (i = 0; i <= 100; i++)
                    {
                        sw.WriteLine(rnd.Next(0, 21));
                    }
                }
                tsmImport.Enabled = true;
            }
        }

        private void tsmImport_Click(object sender, EventArgs e)
        {
            string addthis = "";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(sfd.FileName))
                {
                    while ((addthis = sr.ReadLine()) != null)
                    {
                        numbers.Add(int.Parse(addthis));
                    }

                }
                tbOne.Text = numbers[shown].ToString();
                pbInfo.Value = shown+1;
                btnForward.Enabled = true;
                btnBack.Enabled = true;
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            shown =shown + 1;
            if (shown > 100)
            {
                shown = 0;
                tbOne.Text = numbers[shown].ToString();
                pbInfo.Value = shown;
            }
            else
            {
                tbOne.Text = numbers[shown].ToString();
                pbInfo.Value = shown;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            shown = shown - 1;
            if (shown <= -1)
            {
                shown = 100;
                tbOne.Text = numbers[shown].ToString();
                pbInfo.Value = shown;
            }
            else
            {
                tbOne.Text = numbers[shown].ToString();
                pbInfo.Value = shown;
            }
        }
        private void tbOne_Leave(object sender, EventArgs e)
        {
            numbers[shown] = int.Parse(tbOne.Text);
        }

        private void tbOne_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
