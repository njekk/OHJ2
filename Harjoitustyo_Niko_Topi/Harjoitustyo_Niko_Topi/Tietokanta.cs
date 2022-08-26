using Harjoitustyo_Niko_Topi.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Harjoitustyo_Niko_Topi
{
    public partial class Tietokanta : Form
    {
        List<Henkilot> Henkilot = new List<Henkilot>();
        public string personfile = "C:\\Temp\\Henkilosto.json";
        public string[] lines;
        public string[] Titlefile;
        public string[] unitfile;
        public string Postnumbers, Title, Unit;
        public Tietokanta()
        {
            
            InitializeComponent();
            createPost();
            createTitle();                  // Luodaan tarvittavat tiedostot tarvittaessa
            createUnit();
            Henkilot = DeserializeJSON();
            if (Henkilot == null)
            {
                Henkilot = new List<Henkilot>();
            }
            populateHenkilotDgv();
            getPostnumbers();
            getTitle();                     // Haetaan aiemmat tiedot tiedostoista
            getUnit();
            cbPostalcode.MaxLength = 5;
        }
        private void createPost()
        {
            FileInfo pf = new FileInfo("C:\\Temp\\Postinumero.txt");
            if (pf.Exists== false)
            {
                using (FileStream fs = pf.Create())
                {

                }
            }
        }
        private void getPostnumbers() // luetaan tiedostossa olevat tiedot ja lisätään ne comboboxin listaan
        {
            using (StreamReader readpost = new StreamReader("C:\\Temp\\Postinumero.txt"))
            {
                while (readpost.EndOfStream == false)
                {
                    Postnumbers = readpost.ReadLine();
                    string[] City = Postnumbers.Split(',');
                    if (Postnumbers == "")
                    {

                    }
                    else
                    {
                        cbPostalcode.Items.Add(City[0]);
                    }
                }
            }
        }
        private void createTitle() // Mikäli nimike tiedostoa ei ole se luodaan ohjelman käynnistyessä mikäli se löytyy ei tehdä mitään
        {
            FileInfo tf = new FileInfo("C:\\Temp\\Nimike.txt");
            if (tf.Exists != true)
            {
                using (FileStream fs = tf.Create())
                {
                }
            }
            
        }
        private void getTitle() // luetaan tiedostossa olevat tiedot ja lisätään ne comboboxin listaan
        {
            using (StreamReader readtitle = new StreamReader("C:\\Temp\\Nimike.txt"))
            {
                while (readtitle.EndOfStream == false)
                {
                    Title = readtitle.ReadLine();
                    if (Title == "")
                    {
                    }
                    else
                    {
                        cbTitle.Items.Add(Title);
                    }
                }
            }
        }
        private void createUnit() // Mikäli yksikkö tiedostoa ei ole se luodaan ohjelman käynnistyessä mikäli se löytyy ei tehdä mitään
        {
            FileInfo uf = new FileInfo("C:\\Temp\\Yksikko.txt");
            if (uf.Exists != true)
            {
                using (FileStream fs = uf.Create())
                {
                }
            }
            
        }
        private void getUnit() // luetaan tiedostossa olevat tiedot ja lisätään ne comboboxin listaan
        {
            using (StreamReader readunit = new StreamReader("C:\\Temp\\Yksikko.txt"))
            {
                while (readunit.EndOfStream == false)
                {
                    Unit = readunit.ReadLine();
                    if (Unit == "")
                    {
                    }
                    else
                    {
                        cbUnit.Items.Add(Unit);
                    }
                }
            }
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void btnSave_Click(object sender, EventArgs e) 
        {
            if (tbFirstnames.Text == "" || tbSurname.Text == "" || tbNickname.Text == "" || tbID.Text == "" || tbStreetaddress.Text == "" || tbHomeaddress.Text == "" || cbPostalcode.Text == "" || tbPostalarea.Text == "" || cbTitle.Text == "" || cbUnit.Text == "")
            {
                if (btnEnglish.Enabled == false)
                {
                    MessageBox.Show("Please fill all information!");
                }
                else if(btnEnglish.Enabled == true)
                {
                    MessageBox.Show("Täytä kaikki tiedot!");
                }
                if (tbFirstnames.Text == "")
                {
                    tbFirstnames.BackColor = Color.Salmon;                  // tarkistetaan että kaikki tarvittavat tiedot ovat kirjoitettu
                }
                else
                {
                    tbFirstnames.BackColor = Color.White;
                }
                if (tbSurname.Text == "")
                {
                    tbSurname.BackColor = Color.Salmon;
                }
                else
                {
                    tbSurname.BackColor = Color.White;
                }
                if (tbNickname.Text == "")
                {
                    tbNickname.BackColor = Color.Salmon;
                }
                else
                {
                    tbNickname.BackColor = Color.White;
                }
                if (tbID.Text == "")
                {
                    tbID.BackColor = Color.Salmon;
                }
                else
                {
                    tbID.BackColor = Color.White;
                }
                if (tbStreetaddress.Text == "")
                {
                    tbStreetaddress.BackColor = Color.Salmon;
                }
                else
                {
                    tbStreetaddress.BackColor = Color.White;
                }
                if (tbHomeaddress.Text == "")
                {
                    tbHomeaddress.BackColor = Color.Salmon;
                }
                else
                {
                    tbHomeaddress.BackColor = Color.White;
                }
                if (cbPostalcode.Text == "")
                {
                    cbPostalcode.BackColor = Color.Salmon;
                }
                else
                {
                    cbPostalcode.BackColor = Color.White;
                }
                if (tbPostalarea.Text == "")
                {
                    tbPostalarea.BackColor = Color.Salmon;
                }
                else
                {
                    tbPostalarea.BackColor = Color.White;
                }
                if (cbTitle.Text == "")
                {
                    cbTitle.BackColor = Color.Salmon;
                }
                else
                {
                    cbTitle.BackColor = Color.White;
                }
                if (cbUnit.Text == "")
                {
                    cbUnit.BackColor = Color.Salmon;
                }
                else
                {
                    cbUnit.BackColor = Color.White;
                }
            }
            else
            {
                tbFirstnames.BackColor = Color.White;
                tbSurname.BackColor = Color.White;
                tbNickname.BackColor = Color.White;
                tbID.BackColor = Color.White;
                tbStreetaddress.BackColor = Color.White;                    //kun kaikki tiedot on lisätty vaihdetaan laatikoiden väri valkoiseksi ja annetaan käyttäjän tallentaa
                tbHomeaddress.BackColor = Color.White;
                cbPostalcode.BackColor = Color.White;
                tbPostalarea.BackColor = Color.White;
                cbTitle.BackColor = Color.White;
                cbUnit.BackColor = Color.White;
                using (StreamWriter writetolog = new StreamWriter("C:\\Temp\\Log.txt", true))
                {
                    writetolog.WriteLine("Käyttäjä lisäsi tiedot" + " " + tbFirstnames.Text + " " + tbSurname.Text + " " + tbNickname.Text + " " + tbID.Text + " " + cbPostalcode.Text + " " + tbPostalarea.Text + " " + dtpStart.Value.ToString() + " " + dtpEnd.Value.ToString() + " " + cbTitle.Text + " " + cbUnit.Text);
                }//kirjoitetaan Log tiedostoon käyttäjän tekemä muutos
                int i, found = 0;
                string Filepathpost = "C:\\Temp\\Postinumero.txt";
                lines = File.ReadAllLines(Filepathpost);                // jokainen string tyylinen taulukko päivitetään kun buttonia painetaan
                Titlefile = File.ReadAllLines("C:\\Temp\\Nimike.txt");
                unitfile = File.ReadAllLines("C:\\Temp\\Yksikko.txt");
                Model.Henkilot h = new Model.Henkilot();
                h.Etunimi = tbFirstnames.Text;
                h.Sukunimi = tbSurname.Text;
                h.Kutsumanimi = tbNickname.Text;
                h.Henkilotunnus = tbID.Text;
                h.Katuosoite = tbStreetaddress.Text;
                h.Kotiosoite = tbHomeaddress.Text;
                using (StreamReader readpost = new StreamReader("C:\\Temp\\Postinumero.txt"))
                {
                    for (i = 0; i < lines.Length; i++)
                    {
                        Postnumbers = readpost.ReadLine();
                        if (cbPostalcode.Text == "")
                        {

                        }
                        else if (cbPostalcode.Text != "")           //tarkastetaan onko postinumero jo olemassa tiedostossa 
                        {
                            if (Postnumbers == "")                  
                            {

                            }
                            else if (Postnumbers != "")
                            {
                                string[] City = Postnumbers.Split(',');
                                if (cbPostalcode.Text == City[0] && tbPostalarea.Text == City[1])
                                {

                                }
                                else
                                {
                                    found++;
                                }
                            }
                        }
                    }
                }
                if (found >= lines.Length) //mikäli on sitä ei listätä uudestaan jos ei se käydään kirjoittamassa muotoon postinumero,postitoimipaikka 
                {
                    using (StreamWriter writePost = new StreamWriter(Filepathpost, true)) // ja käydään lisäämässä se comboboxin listaan
                    {
                        writePost.WriteLine(cbPostalcode.Text + ',' + tbPostalarea.Text);
                    }
                    updatePost();
                }
                h.Postinumero = cbPostalcode.Text;
                Postnumbers = cbPostalcode.Text;
                h.Postitoimipaikka = tbPostalarea.Text;
                h.Alkamispaiva = dtpStart.Value;
                if (chbUntil.Checked == true)
                {
                    h.Toistaiseksi = "Kyllä"; //tarkistetaan onko toistaiseksi voimassa checkbox painettu
                }
                else
                {
                    h.Toistaiseksi = "Ei";
                    h.Lopetuspaiva = dtpEnd.Value;
                }
                h.Nimike = cbTitle.Text;
                Title = cbTitle.Text;
                using (StreamWriter writeTitle = new StreamWriter("C:\\Temp\\Nimike.txt", true))// kirjoitetaan tiedostoon nimikkeet
                {                                                                               //samalla tarkistetaan onko nimike jo tiedostossa 
                    found = 0;
                    for (i = 0; i < Titlefile.Length; i++)
                    {
                        if (cbTitle.Text == Titlefile[i])
                        {

                        }
                        else if (cbTitle.Text != Titlefile[i] || Titlefile[i] == "")
                        {
                            found++;
                        }
                        else if (Titlefile.Length <= 0)
                        {
                            writeTitle.WriteLine(cbTitle.Text);
                            updatetitle();
                        }
                        if (found == Titlefile.Length)
                        {
                            if (cbTitle.Text == "")
                            {

                            }
                            else
                            {
                                writeTitle.WriteLine(cbTitle.Text);
                                updatetitle();
                            }
                        }
                    }
                    for (i = 0; i == Titlefile.Length; i++)
                    {
                        if (Titlefile.Length <= 0)
                        {
                            writeTitle.WriteLine(cbTitle.Text);
                            updatetitle();
                        }
                    }
                }
                h.Yksikko = cbUnit.Text;
                using (StreamWriter writeUnit = new StreamWriter("C:\\Temp\\Yksikko.txt", true)) // kirjoitetaan tiedostoon yksikkö
                {                                                                               //samalla tarkistetaan onko yksikkö jo tiedostossa
                    found = 0;
                    for (i = 0; i < unitfile.Length; i++)
                    {
                        if (cbUnit.Text == unitfile[i])
                        {

                        }
                        else if (cbUnit.Text != unitfile[i] || unitfile[i] == "")
                        {
                            found++;
                        }
                        else if (unitfile.Length <= 0)
                        {
                            writeUnit.WriteLine(cbUnit.Text);
                            updateunit();
                        }
                        if (found == unitfile.Length)
                        {
                            if (cbUnit.Text == "")
                            {

                            }
                            else
                            {
                                writeUnit.WriteLine(cbUnit.Text);
                                updateunit();
                            }
                        }
                    }
                    for (i = 0; i == unitfile.Length; i++)
                    {
                        if (unitfile.Length <= 0)
                        {
                            writeUnit.WriteLine(cbUnit.Text);
                            updateunit();
                        }
                    }
                }
                Henkilot.Add(h);
                chbUntil.Checked = false;
                dtpEnd.Visible = true;
                dtpEnd.Enabled = true;      //Nollataan ilmoitukset ja tekstikentät
                lblEnd.Visible = true;
                lblCheck.Visible = false;
                populateHenkilotDgv(); // kutsutaan json tiedoston päivitystä jotta saadaan tiedot datagridviewiin
                initializeControls();//kutsutaan funktiota jossa tyhjennetään kaikki tiedot 
            }
            
        }
        private void Delete()//kutsuttu funktio jossa poistetaan tiedot niin datagridviewistä kuin json tiedostosta
        {
            try
            {
                Model.Henkilot h = new Model.Henkilot();
                Henkilot.RemoveAll(Henkilot => h.Etunimi == tbFirstnames.Text);
                Henkilot.RemoveAll(Henkilot => h.Sukunimi == tbSurname.Text);
                Henkilot.RemoveAll(Henkilot => h.Kutsumanimi == tbNickname.Text);
                Henkilot.RemoveAll(Henkilot => h.Henkilotunnus == tbID.Text);
                Henkilot.RemoveAll(Henkilot => h.Kotiosoite == tbHomeaddress.Text);
                Henkilot.RemoveAll(Henkilot => h.Katuosoite == tbStreetaddress.Text);
                Henkilot.RemoveAll(Henkilot => h.Postinumero == cbPostalcode.Text);
                Henkilot.RemoveAll(Henkilot => h.Postitoimipaikka == tbPostalarea.Text);
                Henkilot.RemoveAll(Henkilot => h.Nimike == cbTitle.Text);
                Henkilot.RemoveAll(Henkilot => h.Yksikko == cbUnit.Text);
            }
            catch (Exception ex) // mikäli tulee virhe se ilmoitetaan ilman että ohjelma kaatuu
            {
                throw ex;
            }

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetolog = new StreamWriter("C:\\Temp\\Log.txt", true)) //kirjoitetaan logiin käyttäjän poistamat tiedot
            {
                writetolog.WriteLine("Käyttäjä poisti tiedot" + " " + tbFirstnames.Text + " " + tbSurname.Text + " " + tbNickname.Text + " " + tbID.Text + " " + cbPostalcode.Text + " " + tbPostalarea.Text + " " + dtpStart.Value.ToString() + " " + dtpEnd.Value.ToString() + " " + cbTitle.Text + " " + cbUnit.Text);
            }
            if (btnEnglish.Enabled == true)
            {
                DialogResult Result = MessageBox.Show("Haluatko varmasti poistaa tiedot?", "Olet poistamassa tietoja", MessageBoxButtons.YesNo);// kysytään haluaako käyttäjä varmasti poistaa valitut tiedot
                if (Result == DialogResult.Yes)                                                                                                 // jos vastaus on kyllä poistetaan tiedot tiedostosta sekä listasta jos vastaus on ei ei poisteta.
                {
                    Delete();
                    tbFirstnames.Text = "";
                    tbSurname.Text = "";
                    tbNickname.Text = "";
                    tbID.Text = "";
                    tbStreetaddress.Text = "";
                    tbHomeaddress.Text = "";
                    cbPostalcode.Text = "";
                    cbPostalcode.Items.Remove(cbPostalcode.Text);
                    tbPostalarea.Text = "";
                    dtpStart.Text = "";
                    dtpEnd.Text = "";
                    cbTitle.Text = "";
                    cbUnit.Text = "";
                }
                else if (Result == DialogResult.No)
                {

                }
            }
            else if (btnEnglish.Enabled == false) // englannin kielen käännös
            {
                DialogResult Result = MessageBox.Show("Are you sure you want to delete the data? ", " You are about to delete the data ", MessageBoxButtons.YesNo);
                if (Result == DialogResult.Yes)
                {
                    Delete();
                    tbFirstnames.Text = "";
                    tbSurname.Text = "";
                    tbNickname.Text = "";
                    tbID.Text = "";
                    tbStreetaddress.Text = "";
                    tbHomeaddress.Text = "";
                    cbPostalcode.Items.Remove(cbPostalcode.Text);
                    cbPostalcode.Text = "";
                    tbPostalarea.Text = "";
                    dtpStart.Text = "";
                    dtpEnd.Text = "";
                    cbTitle.Text = "";
                    cbUnit.Text = "";
                }

                else if (Result == DialogResult.No)
                {

                }
            }
        }
        private void initializeControls() // alustetaan kaikki tiedot tyhjiksi uusia tietoja varten
        {
            tbFirstnames.Text = "";
            tbSurname.Text = "";
            tbNickname.Text = "";
            tbID.Text = "";
            tbStreetaddress.Text = "";
            tbHomeaddress.Text = "";
            cbPostalcode.Text = "";
            tbPostalarea.Text = "";
            dtpStart.Text = "";
            dtpEnd.Text = "";
            cbTitle.Text = "";
            cbUnit.Text = "";
        }
        private void cbPostalcode_KeyPress(object sender, KeyPressEventArgs e) // posti combobox ei hyväksy muita kuin numeroita ja backspace merkin
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 48)
            {
                e.Handled = true;
            }
        }
        private void dtpStart_Leave(object sender, EventArgs e)// alustetaan datetimepicker tälle päivälle
        {
            dtpStart.MinDate = DateTime.Today;
        }

        private void dtpEnd_Leave(object sender, EventArgs e)// alustetaan datetimepicker tälle päivälle
        {
            dtpEnd.MinDate = DateTime.Today;
        }
        private void SerializeJSON(List<Henkilot> input)//kirjoitetaan json tiedostoon
        {
            string json = JsonConvert.SerializeObject(input);
            //write string to file
            System.IO.File.WriteAllText(personfile, json);
        }
        private List<Henkilot> DeserializeJSON()//luetaan json tiedostosta tiedot datagridviewiin
        {
            if (File.Exists(personfile))
            {
                try
                {
                    using (StreamReader r = new StreamReader(personfile))
                    {
                        string json = r.ReadToEnd();
                        return JsonConvert.DeserializeObject<List<Henkilot>>(json);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
            else
                return null;
        }
        private void chbUntil_Click(object sender, EventArgs e)//checkbox tarkistus onko painettu vai ei
        {
            if (chbUntil.Checked == true)
            {
                dtpEnd.Enabled = false;
                dtpEnd.Visible = false;
                lblEnd.Visible = false;
            }
            else if (chbUntil.Checked != true)
            {
                dtpEnd.Enabled = true;
                dtpEnd.Visible = true;
                lblEnd.Visible = true;
            }
        }

        public void tbID_Leave(object sender, EventArgs e)              //henkilötunnuksen tarkistus
        {
            string idnum, copy, check = "0123456789ABCDEFHJKLMNPRSTUVWXY";
            int converted, jj;
            idnum = tbID.Text;

            if (idnum.Length == 11)
            {
                copy = idnum.Remove(6, 1);
                copy = copy.Remove(9, 1);
                converted = int.Parse(copy);
                jj = converted % 31;

                if (idnum[10] == check[jj])
                {
                    tbID.BackColor = Color.White;
                    lblCheck.Text = "OK";
                    lblCheck.Visible = true;
                }
                else
                {
                    tbID.BackColor = Color.Salmon;
                    tbID.Focus();
                }
            }
            else
            {
                tbID.BackColor = Color.Salmon;
                tbID.Focus();
                if (btnEnglish.Enabled == true)
                {
                    tbID.BackColor = Color.Salmon;
                    tbID.Focus();
                    lblCheck.Visible = true;
                    lblCheck.Text = "Henkilötunnus on väärin";
                }
                else if (btnEnglish.Enabled == false)
                {
                    tbID.BackColor = Color.Salmon;
                    tbID.Focus();
                    lblCheck.Visible = true;
                    lblCheck.Text = "The personal ID is incorrect";
                }
            }
        }
        

        private void updatetitle() //päivitetään combobox listaa
        {
            string Updatetitle;
            int i, found = 0;
            Updatetitle = cbTitle.Text;
            for (i = 0; i < Titlefile.Length; i++)
            {
                if (Titlefile[i] == cbTitle.Text)
                {

                }
                else if (cbTitle.Text != Titlefile[i] || Titlefile[i] == "")
                {
                    found++;
                }
                if (found == Titlefile.Length)
                {
                    cbTitle.Items.Add(Updatetitle);
                }
            }
            for (i = 0; i == Titlefile.Length; i++)
            {
                cbTitle.Items.Add(Updatetitle);
            }
        }
        
        private void updateunit()//päivitetään combobox listaa
        {
            string Updateunit;
            int i, found = 0;
            Updateunit = cbUnit.Text;
            for (i = 0; i < unitfile.Length; i++)
            {
                if (cbUnit.Text == unitfile[i])
                {

                }
                else if (cbUnit.Text != unitfile[i] || unitfile[i] == "")
                {
                    found++;
                }
                if (found == unitfile.Length)
                {
                    cbUnit.Items.Add(Updateunit);
                }
            }
            for (i = 0; i == unitfile.Length; i++)
            {
                cbUnit.Items.Add(Updateunit);
            }
        }
        

        private void updatePost()//päivitetään combobox listaa
        {
            string updatepost;
            int i, found = 0;
            updatepost = cbPostalcode.Text;
            for (i = 0; i < lines.Length; i++)
            {
                if (lines[i] == cbPostalcode.Text)
                {

                }
                else if (cbPostalcode.Text != lines[i] || lines[i] == "")
                {
                    found++;
                }
                if (found == lines.Length)
                {
                    if (cbPostalcode.Text == "")
                    {

                    }
                    else
                    {
                        if (Postnumbers != "")
                        {
                            string[] City = Postnumbers.Split(',');
                            if (cbPostalcode.Text == City[0])
                            {

                            }
                            else if (cbPostalcode.Text != City[0])
                            {
                                cbPostalcode.Items.Add(updatepost);
                            }
                        }
                    }
                }
            }
            for (i = 0; i == lines.Length; i++)
            {
                cbPostalcode.Items.Add(updatepost);
            }
        }
        private void populateHenkilotDgv()
        {
            BindingSource source = new BindingSource();
            source.DataSource = Henkilot;
            dgwInfo.DataSource = source;
        }

        private void Tietokanta_FormClosing(object sender, FormClosingEventArgs e)//käyttöliittymästä poistuessa kysytään poistuminen jos tietoja on laatikoissa
        {
            if (tbFirstnames.Text != "" || tbSurname.Text != "" || tbNickname.Text != "" || tbID.Text != "" || tbStreetaddress.Text != "" || tbHomeaddress.Text != "" || cbPostalcode.Text != "" || tbPostalarea.Text != "" || cbTitle.Text != "" || cbUnit.Text != "")
            {
                if (btnEnglish.Enabled == true)
                {
                    DialogResult Result = MessageBox.Show("Haluatko poistua ilman tietojen tallennusta?", "Olet poistumassa tallentamatta!", MessageBoxButtons.YesNo);
                    if (Result == DialogResult.Yes)
                    {
                        using (StreamWriter writelog = new StreamWriter("C:\\Temp\\Log.txt", true))
                        {
                            writelog.WriteLine("Käyttäjä sulki sovellusken");
                        }
                        Application.Exit();
                    }
                    else if (Result == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                }
                else if (btnEnglish.Enabled == false)
                {
                    DialogResult Result = MessageBox.Show("Do you want to leave without saving data?", "You are leaving without saving!", MessageBoxButtons.YesNo);
                    if (Result == DialogResult.Yes)
                    {
                        using (StreamWriter writelog = new StreamWriter("C:\\Temp\\Log.txt", true))
                        {
                            writelog.WriteLine("Käyttäjä sulki sovellusken");
                        }
                        Application.Exit();
                    }
                    else if (Result == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                }
            }
            else
            {
                using (StreamWriter writelog = new StreamWriter("C:\\Temp\\Log.txt", true))//kirjoitetaan logiin sulkeminen
                {
                    writelog.WriteLine("Käyttäjä sulki sovellusken");
                }
                SerializeJSON(Henkilot);
                Application.Exit();
            }

        }

        private void dgwInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (tbFirstnames.Text != "" || tbSurname.Text != "" || tbNickname.Text != "" || tbID.Text != "" || tbStreetaddress.Text != "" || tbHomeaddress.Text != "" || cbPostalcode.Text != "" || tbPostalarea.Text != "" || cbTitle.Text != "" || cbUnit.Text != "")
            {
                if (btnEnglish.Enabled == true)
                {
                    MessageBox.Show("Et voi valita tietoja muokattavaksi ennen kuin olet valinnut toiminnon nykyisille!");
                }
                else if (btnEnglish.Enabled == false)
                {
                    MessageBox.Show("You cannot select data to edit until you have selected the function at the beginning!");
                }
            }
            else
            {
                if (e.RowIndex >= 0)
                {
                    Henkilot h = Henkilot[e.RowIndex];
                    tbFirstnames.Text = h.Etunimi;
                    tbSurname.Text = h.Sukunimi;
                    tbNickname.Text = h.Kutsumanimi;
                    tbID.Text = h.Henkilotunnus;
                    tbStreetaddress.Text = h.Katuosoite;
                    tbHomeaddress.Text = h.Kotiosoite;
                    cbPostalcode.Text = h.Postinumero;
                    tbPostalarea.Text = h.Postitoimipaikka;
                    dtpStart.Value = h.Alkamispaiva;
                    if (h.Toistaiseksi == "Kyllä")
                    {
                        chbUntil.Checked = true;
                        lblEnd.Visible = false;
                        dtpEnd.Visible = false;
                    }
                    else if (h.Toistaiseksi == "Ei")
                    {
                        chbUntil.Checked = false;
                        dtpEnd.Value = h.Lopetuspaiva;
                        lblEnd.Visible = true;
                        dtpEnd.Visible = true;
                    }
                    cbTitle.Text = h.Nimike;
                    cbUnit.Text = h.Yksikko;
                    Henkilot.Remove(h);
                    populateHenkilotDgv();
                    using (StreamWriter writetolog = new StreamWriter("C:\\Temp\\Log.txt", true))
                    {
                        writetolog.WriteLine("Käyttäjä valitsi tiedot muokattaviksi" + " " + h.Etunimi + " " + h.Sukunimi + " " + h.Kutsumanimi + " " + h.Henkilotunnus + " " + h.Katuosoite + " " + h.Katuosoite + " " + h.Postinumero + " " + h.Postitoimipaikka + " " + h.Alkamispaiva + " " + h.Lopetuspaiva + " " + h.Nimike + " " + h.Yksikko);
                    }
                }
            }
        }

        private void tbPostalarea_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgwInfo_Click(object sender, EventArgs e)
        {
        }

        private void stripCrypt_Click(object sender, EventArgs e) // salataan tiedostot joko kansiossa tai sitten tiedostona itsessän 
        {

        }

        private void cbPostalcode_TextUpdate(object sender, EventArgs e)
        {

        }

        private void cbPostalcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbPostalcode_Leave(object sender, EventArgs e)
        {
            string Postalareas; //ennakoiva tekstin syöttö mikäli ohjelma löytää tiedostosta oikeat arvot se syöttää ne käyttäjälle jos ei löydä ohjelma ei tee mitään
            try
            {
                using (StreamReader readpost = new StreamReader("C:\\Temp\\Postinumero.txt"))
                {
                    while (readpost.EndOfStream == false)
                    {
                        Postnumbers = readpost.ReadLine();
                        if (Postnumbers == "")
                        {

                        }
                        else if (Postnumbers != "")
                        {
                            string[] City = Postnumbers.Split(',');
                            if (cbPostalcode.Text == City[0])
                            {
                                Postalareas = City[1].ToString();
                                tbPostalarea.Text = Postalareas.ToString();
                            }
                            else
                            {

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public int Nickname = 1; //käytetään määrittämään laitetaanko aakkosjärjestykseen vai toisinpäin
        public int Surname = 1;
        public int iTitle = 1;
        private void dgwInfo_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                dgwInfo.DataSource = null;
                dgwInfo.DataSource = SortBySurname();
            }
            if (e.ColumnIndex == 2)
            {
                dgwInfo.DataSource = null;
                dgwInfo.DataSource = SortByNickname();
            }
            if (e.ColumnIndex == 11)
            {
                dgwInfo.DataSource = null;
                dgwInfo.DataSource = SortByTitle();
            }
        }
        private List<Henkilot> SortBySurname() // Tällä järjestellään lista sukunimen avulla
        {
            if (Surname == 1)
            {
                using (StreamWriter writelog = new StreamWriter("C:\\Temp\\Log.txt", true))
                {
                    writelog.WriteLine("Käyttäjä järjesti sukunimen mukaan A-Z");
                }
                List<Henkilot> objListHenkilo = Henkilot;
                objListHenkilo.Sort(
                    delegate (Henkilot p1, Henkilot p2)
                    {
                        return p1.Sukunimi.CompareTo(p2.Sukunimi);
                    }
                    );
                Surname *= -1;
                return objListHenkilo;
            }

            if (Surname == -1)
            {
                using (StreamWriter writelog = new StreamWriter("C:\\Temp\\Log.txt", true))
                {
                    writelog.WriteLine("Käyttäjä järjesti sukunimen mukaan Z-A");
                }
                List<Henkilot> objListHenkilo = Henkilot;
                objListHenkilo.Sort(
                    delegate (Henkilot p1, Henkilot p2)
                    {
                        return p2.Sukunimi.CompareTo(p1.Sukunimi);
                    }
                    );
                Surname *= -1;
                return objListHenkilo;
            }
            return null;
        }
        private List<Henkilot> SortByNickname() // Tällä järjestellään lista etunimen avulla.
        {
            if (Nickname == 1)
            {
                using (StreamWriter writelog = new StreamWriter("C:\\Temp\\Log.txt", true))
                {
                    writelog.WriteLine("Käyttäjä järjesti kutsumanimen mukaan A-Z");
                }
                List<Henkilot> objListHenkilo = Henkilot;
                objListHenkilo.Sort(
                    delegate (Henkilot p1, Henkilot p2)
                    {
                        return p1.Kutsumanimi.CompareTo(p2.Kutsumanimi);
                    }
                    );
                Nickname *= -1;
                return objListHenkilo;
            }

            if (Nickname == -1)
            {
                using (StreamWriter writelog = new StreamWriter("C:\\Temp\\Log.txt", true))
                {
                    writelog.WriteLine("Käyttäjä järjesti kutsumanimen mukaan Z-A");
                }
                List<Henkilot> objListHenkilo = Henkilot;
                objListHenkilo.Sort(
                    delegate (Henkilot p1, Henkilot p2)
                    {
                        return p2.Kutsumanimi.CompareTo(p1.Kutsumanimi);
                    }
                    );
                Nickname *= -1;
                return objListHenkilo;
            }
            return null;
        }
        private List<Henkilot> SortByTitle()
        {
            if (iTitle == 1)
            {
                using (StreamWriter writelog = new StreamWriter("C:\\Temp\\Log.txt", true))
                {
                    writelog.WriteLine("Käyttäjä järjesti nimikkeen mukaan A-Z");
                }
                List<Henkilot> objListHenkilo = Henkilot;
                objListHenkilo.Sort(
                    delegate (Henkilot p1, Henkilot p2)
                    {
                        return p1.Nimike.CompareTo(p2.Nimike);
                    }
                    );
                iTitle *= -1;
                return objListHenkilo;
            }

            if (iTitle == -1)
            {
                using (StreamWriter writelog = new StreamWriter("C:\\Temp\\Log.txt", true))
                {
                    writelog.WriteLine("Käyttäjä järjesti nimikkeen mukaan Z-A");
                }
                List<Henkilot> objListHenkilo = Henkilot;
                objListHenkilo.Sort(
                    delegate (Henkilot p1, Henkilot p2)
                    {
                        return p2.Nimike.CompareTo(p1.Nimike);
                    }
                    );
                iTitle *= -1;
                return objListHenkilo;
            }
            return null;
        }

        private void Tietokanta_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFinnish_Click(object sender, EventArgs e)//kieliasetukset
        {
            using (StreamWriter writelog = new StreamWriter("C:\\Temp\\Log.txt", true))     //Kielen vaihto suomeksi
            {
                writelog.WriteLine("Käyttäjä vaihtoi kielen Suomeksi");
            }
            btnFinnish.Enabled = false;
            btnEnglish.Enabled = true;
            lblFirstname.Text = "Etunimet";
            lblSurname.Text = "Sukunimi";
            lblNickname.Text = "Kutsumanimi";
            lblID.Text = "Henkilötunnus";
            lblStreet.Text = "Katuosoite";
            lblHome.Text = "Kotiosoite";
            lblPostnumber.Text = "Postinumero";
            lblPost.Text = "Postitoimipaikka";
            lblStart.Text = "Alkamispäivä";
            lblEnd.Text = "Loppumispäivä";
            chbUntil.Text = "Toistaiseksi voimassa";
            lblTitle.Text = "Nimike";
            lblUnit.Text = "Yksikkö";
            tiedostoToolStripMenuItem.Text = "Tiedosto";
            stripSave.Text = "Tallenna";
            stripDelete.Text = "Poista";
            btnSave.Text = "Tallenna";
            btnDelete.Text = "Poista";
            if (tbID.Text == "" || tbID.TextLength == 11)
            {

            }
            else
            {
                lblCheck.Text = "Henkilötunnus on väärin";

            }
        }

        private void btnEnglish_Click(object sender, EventArgs e)//kieliasetukset
        {
            using (StreamWriter writelog = new StreamWriter("C:\\Temp\\Log.txt", true))     // Kielen vaihto englanniksi
            {
                writelog.WriteLine("Käyttäjä vaihtoi kielen Englanniksi");
            }
            btnEnglish.Enabled = false;
            btnFinnish.Enabled = true;
            lblFirstname.Text = "Firstname(s)";
            lblSurname.Text = "Surname";
            lblNickname.Text = "Nickname";
            lblID.Text = "ID number";
            lblStreet.Text = "Street address";
            lblHome.Text = "Home address";
            lblPostnumber.Text = "Postnumber";
            lblPost.Text = "Postalarea";
            lblStart.Text = "Starting day";
            lblEnd.Text = "Ending day";
            chbUntil.Text = "Until further notice";
            lblTitle.Text = "Title";
            lblUnit.Text = "Unit";
            tiedostoToolStripMenuItem.Text = "File";
            stripSave.Text = "Save";
            stripDelete.Text = "Delete";
            btnSave.Text = "Save";
            btnDelete.Text = "Delete";
            if (tbID.Text == "" || tbID.TextLength == 11)
            {
            }
            else
            {
                lblCheck.Text = "The personal ID is incorrect";
            }
        }
    }
}

