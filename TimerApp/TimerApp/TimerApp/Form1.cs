using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerApp
{
    public partial class Form1 : Form
    {
        bool isactive;
        double seconds;
        int i;
        int j;
        Button btnMybutton = new System.Windows.Forms.Button();
        public Form1()
        {
            InitializeComponent();
        }
        private void chancePosition()
        {
            Random rnd = new Random();
            int x = rnd.Next(this.Width - 300);
            int y = rnd.Next(this.Height - 200);
            timer1.Start();
            btnMybutton.Location = new System.Drawing.Point(x, y);
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            seconds = 0;
            isactive = false;
            timer2.Enabled = true;
            isactive = true;
            
            Random rnd = new Random();
            int x = rnd.Next(this.Width-10);
            int y = rnd.Next(this.Height);
            timer1.Enabled = true;

            btnMybutton.Location = new System.Drawing.Point(x, y);
            btnMybutton.Name = "btnPlay";
            btnMybutton.Size = new System.Drawing.Size(75, 23);
            btnMybutton.TabIndex = 1;
            btnMybutton.Text = "Click this";
            btnMybutton.UseVisualStyleBackColor = true;

            this.Controls.Add(btnMybutton);

            btnMybutton.Click += new System.EventHandler(this.btnMybutton_Click);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            chancePosition();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void btnMybutton_Click(object sender, EventArgs e)
        {
            i++;

            statusOsumat.Text = i.ToString();
            chancePosition();
            timer1.Interval -= 200;

        }

        private void statusAika_Click(object sender, EventArgs e)
        {
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isactive)
            {
                seconds++;
            }
            statusAika.Text = string.Format("{0}", seconds);
        }

        private void statusOsumat_Click(object sender, EventArgs e)
        {
          
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            j++;
            if (j == 3)
            {
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show("Peli päättyi! Klikkasit nappia " + statusOsumat.Text + " kertaa "+ statusAika.Text +" sekunnissa");
                statusOsumat.Text = "0";
            }
        }
    }
}
