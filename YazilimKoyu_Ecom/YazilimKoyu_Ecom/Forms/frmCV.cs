using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YazilimKoyu_Ecom.Entity;

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

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
        dbIsTakipEntities db = new dbIsTakipEntities();
        private void frmCV_Load(object sender, EventArgs e)


           
        {
            var egitimler = (from x in db.TblEgitim
                                select new
                                {
                                    x.id,
                                    x.Ad
                                }).ToList();

            lookUpEdit1.Properties.ValueMember = "id";
            lookUpEdit1.Properties.DisplayMember= "Ad";


            lookUpEdit1.Properties.DataSource=egitimler;

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Forms.frmBasvuruGor frm = new Forms.frmBasvuruGor();
            
            frm.Show();
        }
    }
}
