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
    public partial class frmPersoneller : Form
    {
        dbIsTakipEntities db = new dbIsTakipEntities();
        public frmPersoneller()
        {
            InitializeComponent();
        }


        void List()
        {
            var values = (from x in db.TblPersonel
                          select new
                          {

                              x.id,
                              x.Ad,
                              x.Soyad,
                              x.Telefon,
                              x.Mail,
                              Departman = x.TblDepartmanlar.Ad,
                              x.Durum
                          });


            gridControl.DataSource=values.Where(x=>x.Durum==true).ToList();

        }

        private void frmPersoneller_Load(object sender, EventArgs e)
        {
            var departmanlar = (from x in db.TblDepartmanlar 
                                select new {
            x.id,
            x.Ad
            }).ToList();

            lookUpEdit1.Properties.ValueMember = "id";
            lookUpEdit1.Properties.DisplayMember= "Ad";


            lookUpEdit1.Properties.DataSource=departmanlar;


        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List();
        }
     
        private void btnAdd_Click(object sender, EventArgs e)
        {
            TblPersonel t = new TblPersonel();
            t.Ad = txtAd.Text;
            t.Soyad = txtSoyad.Text;
            t.Mail = txtMail.Text;
            t.Telefon = txtTel.Text;
            t.Departman= int.Parse(lookUpEdit1.EditValue.ToString());
            XtraMessageBox.Show("Yeni personel kaydı başarılı bir şekilde gerçekleşti.","Bilgi",MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            
            
            db.TblPersonel.Add(t);
            db.SaveChanges();
            List();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtId.Text);
            var y = db.TblPersonel.Find(x);
            y.Durum=false;
            db.SaveChanges();
            XtraMessageBox.Show("Personel sistemden silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            List();
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int x = int.Parse((string)txtId.Text);
            var deger = db.TblPersonel.Find(x);
            deger.Ad=  txtAd.Text;
            deger.Soyad=  txtSoyad.Text;
            deger.Mail=  txtMail.Text;
            deger.Telefon=  txtTel.Text;
          
            lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("Departman").ToString(); 
            XtraMessageBox.Show("Personel bilgileri güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            db.SaveChanges();
            List();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtId.Text=gridView1.GetFocusedRowCellValue("id").ToString();
            txtAd.Text=gridView1.GetFocusedRowCellValue("Ad").ToString();
            txtSoyad.Text=gridView1.GetFocusedRowCellValue("Soyad").ToString();
            txtMail.Text=gridView1.GetFocusedRowCellValue("Mail").ToString();
            txtTel.Text=gridView1.GetFocusedRowCellValue("Telefon").ToString();
            // lookUpEdit1.EditValue=gridView1.GetFocusedRowCellValue("id").ToString(); buraya daha sonra bakılacak.
        }
    }
}
