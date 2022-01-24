using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimKoyu_Ecom.Forms
{
    public partial class frmCV : Form
    {
        public frmCV()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            Forms.frmCvEleme frm1 = new Forms.frmCvEleme();
          
            frm1.Show();
        }
    }
}
