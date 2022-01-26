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
using System.Net;

namespace YazilimKoyu_Ecom.Forms
{
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }

        private void frmAnasayfa_Load(object sender, EventArgs e)
        {
            webBrowser3.Navigate("https://www.yazilimkoyu.org/");
            webBrowser2.Navigate("https://www.ecompw.com/");
            
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
