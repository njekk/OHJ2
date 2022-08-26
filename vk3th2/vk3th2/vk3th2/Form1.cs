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

namespace vk3th2
{
    public partial class Form1 : Form
    {
        const string FILE = "c:\\temp\\teksti.txt";
        public Form1()
        {
            InitializeComponent();
        }
        private void export()
        {
            string text, check;
            FileInfo fi = new FileInfo(FILE);
            if (fi.Exists != true)
            {
                fi.Create();
            }
            text = tbText.Text;
            check = tbText.Text;
            using (StreamWriter sw = new StreamWriter(FILE))
            {
                sw.Write(text);
            }
        }
        private void import()
        {
            using (StreamReader sr = new StreamReader(FILE))
            {
                tbText.Text = sr.ReadToEnd();
            }
        }

        private void tsmVie_Click(object sender, EventArgs e)
        {
            export();
        }

        private void tsmTuo_Click(object sender, EventArgs e)
        {
            import();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            export();
        }
        private void tsbtnImport_Click(object sender, EventArgs e)
        {
            import();
        }

        private void tsmLopeta_Click(object sender, EventArgs e)
        {
            if (tbText.Text!="")
            {
                MessageBoxButtons btns = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show("Haluatko varmasti sulkea?", "Suljetaan..", btns);
                if ((result == DialogResult.Yes))
                {
                    Application.Exit();
                }
            }
            else
            {
                Application.Exit();
            }
            
        }

        private void tsbReplace_Click(object sender, EventArgs e)
        {
            string inspect, bin = tstbRemove.Text;
            inspect = tbText.Text;
            tbText.Text = inspect.Replace(bin, "");
        }
    }
}
