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
    public partial class frmEgitmenler : Form
    {
        dbIsTakipEntities db = new dbIsTakipEntities();
        public frmEgitmenler()
        {
            InitializeComponent();
        }

        void List()
        {
            var values = (from x in db.TblEgitmenler
                          select new
                          {

                              x.id,
                              x.Ad,
                              x.Soyad,
                              x.Telefon,
                              x.Mail
                             
                             
                          }).ToList();


            gridControl1.DataSource = values;

        }

        private void frmEgitmenler_Load(object sender, EventArgs e)
        {
            
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            List();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TblEgitmenler t = new TblEgitmenler();
            t.Ad = txtAd.Text;
            t.Soyad = txtSoyad.Text;
            t.Mail = txtMail.Text;
            t.Telefon =txtTel.Text;
            




            db.TblEgitmenler.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Eğitmen sisteme eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtId.Text);
            var y = db.TblEgitmenler.Find(x);
            db.TblEgitmenler.Remove(y);
            db.SaveChanges();
            XtraMessageBox.Show("Eğitmen sistemden silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            List();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List();
        }
    }
}
