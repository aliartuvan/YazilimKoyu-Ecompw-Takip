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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }


        dbIsTakipEntities db = new dbIsTakipEntities();

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            var adminValue=db.TblAdmin.Where(x=>x.Kullanici==txtKullaniciAdi.Text && x.Sifre==txtSifre.Text).FirstOrDefault();

            if (adminValue!=null)
            {

                XtraMessageBox.Show("Hoşgeldin " + txtKullaniciAdi.Text + " !","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

                Form1 frm = new Form1();
                frm.Show();
                this.Hide();

            }
            else {

                XtraMessageBox.Show("Hatalı Giriş","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);


            }
        }

        private void btnPersonelGiris_Click(object sender, EventArgs e)
        {
            var personelValue = db.TblPersonel.Where(x => x.Mail==txtKullaniciAdi.Text && x.sifre==txtSifre.Text).FirstOrDefault();

            if (personelValue!=null)
            {

                XtraMessageBox.Show("Hoşgeldin " + txtKullaniciAdi.Text + " !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Forms.frmCV frm = new Forms.frmCV();
                frm.Show();
                this.Hide();

            }
            else {

                XtraMessageBox.Show("Hatalı Giriş", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
