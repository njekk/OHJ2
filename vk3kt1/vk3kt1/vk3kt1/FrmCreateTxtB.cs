using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vk3kt1
{
    public partial class FrmCreateTxtB : Form
    {
        TextBox tbOne = new System.Windows.Forms.TextBox();
        TextBox tbTwo = new System.Windows.Forms.TextBox();
        public FrmCreateTxtB()
        {
            
            InitializeComponent();
        }
        private void btnOne_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int x = btn.Location.X;
            int y = btn.Location.Y;
            if (y== 78)
            {
                tbOne.Location = new System.Drawing.Point(x + 73, 78);
                tbOne.Name = "tbOne";
                tbOne.Size = new System.Drawing.Size(100, 20);
                tbOne.TabIndex = 2;
                this.Controls.Add(this.tbOne);
                tbOne.Leave += new System.EventHandler(this.tbOne_Leave);
            }
            else if (y == 119)
            {
                tbTwo.Location = new System.Drawing.Point(x + 73, 119);
                tbTwo.Name = "tbTwo";
                tbTwo.Size = new System.Drawing.Size(100, 20);
                tbTwo.TabIndex = 4;
                this.Controls.Add(this.tbTwo);
                tbTwo.Leave += new System.EventHandler(this.tbTwo_Leave);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void tbOne_Leave(object sender, EventArgs e)
        {
            btnOne.Text = tbOne.Text;
        }
        private void tbTwo_Leave(object sender, EventArgs e)
        {
            btnTwo.Text = tbTwo.Text;
        }
    }
}
