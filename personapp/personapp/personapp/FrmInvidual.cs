using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personapp
{
    public partial class FrmInvidual : Form
    {
        Model.Person info;

        public FrmInvidual(Model.Person A)
        {
            
            InitializeComponent();
            info = A;
            tbEtunimi.Text = info.Firstname;
            tbSukunimi.Text = info.Surname;

        }

        private void FrmInvidual_Load(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            info.Firstname = tbEtunimi.Text;
            info.Surname = tbSukunimi.Text;
            Close();
        }
    }
}
