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
using System.Runtime.Serialization.Formatters.Binary;

namespace personapp
{
    public partial class Form1 : Form
    {
        public string personsfile = @"C:\temp\persons.json.txt";
        List<Model.Person> ppinfo = new List<Model.Person>();
        public void SerializeJSON(List<Model.Person> input)
        {
            string json = JsonConvert.SerializeObject(input);
            //write string to file
            System.IO.File.WriteAllText(personsfile, json);
        }
        public List<Model.Person> DeserializeJSON()
        {
            if (File.Exists(personsfile))
            {
                try
                {
                    using (StreamReader r = new StreamReader(personsfile))
                    {
                        string json = r.ReadToEnd();
                        return JsonConvert.DeserializeObject<List<Model.Person>>(json);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
                
            }
            else
                return null;
        }
        public Form1()
        {
            InitializeComponent();
            ppinfo = DeserializeJSON();
            if (ppinfo == null)
            {
                ppinfo = new List<Model.Person>();
            }
            populatePerson();
        }
        private void populatePerson()
        {
            BindingSource source = new BindingSource();
            source.DataSource = ppinfo;
            dgvPerson.DataSource = source;
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if (btnInput.Enabled == true)
            {
                Model.Person A = new Model.Person();
                A.Firstname = tbFname.Text;
                A.Surname = tbSname.Text;
                ppinfo.Add(A);
                populatePerson();
                initializeControls();
                statusStrip.Text = "Info added";
            }
        }

        private void dgvPerson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Model.Person A = ppinfo[e.RowIndex];
                tbFname.Text = A.Firstname;
                tbSname.Text = A.Surname;
                ppinfo.Remove(A);
                populatePerson();
            }
        }

        private void tbFname_Leave(object sender, EventArgs e)
        {
            checkpopulate();
        }
        private void checkpopulate()
        {
            if (tbFname.Text.Trim().Length == 0 || tbSname.Text.Trim().Length == 0)
            {
                btnInput.Enabled = false;
            }
            else
            {
                btnInput.Enabled = true;
            }
        }

        private void tbSname_Leave(object sender, EventArgs e)
        {
            checkpopulate();
        }
        private void initializeControls()
        {
            tbFname.Text = "";
            tbSname.Text = "";
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolstripTimer.Text = DateTime.Now.ToString();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            Model.Person A = new Model.Person();

            A.Firstname = tbFname.Text;
            A.Surname = tbSname.Text;

            FrmInvidual fi = new FrmInvidual(A);
            fi.ShowDialog();
            tbFname.Text = A.Firstname;
            tbSname.Text = A.Surname;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerializeJSON(ppinfo);
        }
    }
}
