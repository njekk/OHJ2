using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vk2kt4
{
    public partial class FrmDataGrid : Form
    {
        public FrmDataGrid()
        {
            InitializeComponent();
        }
        public struct measure
        {
            public string name;
            public string target;
            public string function;
            public string location;
            public string getname
            {
                get { return name; }
            }
            public string gettarget
            {
                get { return target; }
            }
            public string getfunction
            {
                get { return function; }
            }
            public string getlocation
            {
                get { return location; }
            }
        }

        private void btnInput_MouseClick(object sender, MouseEventArgs e)
        {
            measure m;
            m.name = txtbName.Text;
            m.target = cbTarget.Text;
            if (chbFunction.Checked==true)
            {
                m.function = "Toiminnassa";
            }
            else
            {
                m.function = "Ei toiminnassa";
            }
            m.location = cbLocation.Text;
            dgwInfo.Rows.Add(m.name, m.target, m.function, m.location);
        }

        private void dgwInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
