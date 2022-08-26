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
using Newtonsoft.Json;
using Harjoitustyo_Niko_Topi.Model;

namespace Harjoitustyo_Niko_Topi
{

    public partial class LogIn : Form
    {
        public LogIn()
        {
            
            InitializeComponent();
            try
            {
                DirectoryInfo Tempinfo = new DirectoryInfo("C:\\Temp\\");
                if (Tempinfo.Exists != true)
                {
                    Tempinfo.Create();
                }
                // Varmistetaan että tarvittavat tiedostot ja tiedot löytyvät
                createuserfile();
            }
            catch (Exception)
            {

            }

        }

        private void createuserfile()
        {
            using (StreamWriter writeusers = new StreamWriter("C:\\Temp\\Kayttaja.txt")) // Luodaan tiedosto ja kirjoitetaan kirjautumistiedot
            {
                FileInfo User = new FileInfo("C:\\Temp\\Kayttaja.txt");
                if (User.Exists != true)
                {
                    User.Create();
                }
                writeusers.WriteLine("Topi");
                writeusers.WriteLine("Topi222");
                writeusers.WriteLine("Niko");
                writeusers.WriteLine("Niko200");
                writeusers.WriteLine("Jukka");
                writeusers.WriteLine("Jukka1234");
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (StreamWriter writelog = new StreamWriter("C:\\Temp\\Log.txt", true))
            {
                FileInfo logfile = new FileInfo("C:\\Temp\\Log.txt");
                if (logfile.Exists != true)
                {
                    logfile.Create();
                }
                string[] userinfo = File.ReadAllLines("C:\\Temp\\Kayttaja.txt");
                if (tbUsername.Text == userinfo[0] && tbPassword.Text == userinfo[1] || tbUsername.Text == userinfo[2] && tbPassword.Text == userinfo[3] || tbUsername.Text == userinfo[4] && tbPassword.Text == userinfo[5]) //tarkistetaan, että kirjautumistiedot ovat oikein
                {
                    //tarkistetaan kuka kirjautuu ja kirjoitetaan se logiin
                    if (tbUsername.Text == userinfo[0] && tbPassword.Text == userinfo[1])
                    {
                        writelog.WriteLine("Topi" + " " + "Leinonen" + " " + Environment.UserDomainName);
                    }
                    else if (tbUsername.Text == userinfo[2] && tbPassword.Text == userinfo[3])
                    {
                        writelog.WriteLine("Niko" + " " + "Jekkonen" + " " + Environment.UserDomainName);
                    }
                    else if (tbUsername.Text == userinfo[4] && tbPassword.Text == userinfo[5])
                    {
                        writelog.WriteLine("Jukka" + " " + Environment.UserDomainName);
                    }
                    try
                    {
                        Tietokanta Tietokanta = new Tietokanta(); // Käynnistetään ohjelma mikäli kirjautumistiedot on oikein
                        Tietokanta.Show();
                        this.Hide();
                    }
                    catch (Exception)
                    {
                        Application.Restart();
                    }
                }
                else
                {
                    MessageBox.Show("Salasana tai käyttäjätunnus on väärin yritä uudelleen");
                }
            }

        }
        private void tbPassword_TextChanged_1(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = true; // Piiloitetaan salasanan näkyminen
        }
    }
}
