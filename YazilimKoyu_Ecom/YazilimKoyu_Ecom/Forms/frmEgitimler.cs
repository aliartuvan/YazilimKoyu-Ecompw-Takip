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
using DevExpress.XtraEditors;

namespace YazilimKoyu_Ecom.Forms
{
    public partial class frmEgitimler : Form
    {

        dbIsTakipEntities db = new dbIsTakipEntities();
        public frmEgitimler()
        {
            InitializeComponent();
        }

        void List()
        {


            var values = (from x in db.TblEgitim
                          select new
                          {

                              x.id,
                              x.Ad,
                              x.Cv,
                              x.Mulakat,
                              x.Baslangic,
                              x.Bitis
                          }).ToList();


            gridControl1.DataSource=values;

        }

        private void frmEgitimler_Load(object sender, EventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }
        
        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TblEgitim t = new TblEgitim();
            t.Ad = txtAd.Text;
            t.Cv = dateCV.DateTime;
            t.Mulakat = dateMulakat.DateTime;
            t.Baslangic = dateBaslangic.DateTime;
            t.Bitis = dateBitis.DateTime;   



            db.TblEgitim.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Eğitim sisteme eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List();

            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtId.Text);
            var y = db.TblEgitim.Find(x);
            db.TblEgitim.Remove(y);
            db.SaveChanges();
            XtraMessageBox.Show( x + " Numaralı eğitim sistemden silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            List();
        }

        private void dateCV_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
