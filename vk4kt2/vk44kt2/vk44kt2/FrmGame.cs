using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vk44kt2
{
    public partial class FrmGame : Form
    {
        public int counter = 0;
        public int drawn;
        public Random rnd = new Random();
        public FrmGame()
        {
            InitializeComponent();
            drawed();
        }
        public void drawed()
        {
            drawn = rnd.Next(1, 101);
        }
        public void compare()
        {
            int gs = int.Parse(tbGuess.Text);
            
            if (drawn > gs)
            {
                tsslHowClose.Text = "liian pieni";
            }
            else if (drawn < gs)
            {
                tsslHowClose.Text = "liian iso";
            }
            else
            {
                tsslHowClose.Text = "Oikein!";
                var result = MessageBox.Show( "Haluatko pelata uudestaan?", "Arvasit oikein " + counter + " yrityksellä!", MessageBoxButtons.YesNo);
                if (result ==DialogResult.Yes)
                {
                    Application.Restart();
                }
                else
                {
                    Application.Exit();
                }

            }
        }
        private void btnGuess_MouseClick(object sender, MouseEventArgs e)
        {
            counter += 1;
            tsslCounter.Text = counter.ToString();
            compare();
        }
    }
}
