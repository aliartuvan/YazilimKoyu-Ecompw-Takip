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
using YazilimKoyu_Ecom.Entity;


namespace YazilimKoyu_Ecom.Forms
{
    public partial class frmCvEleme : Form
    {
        public frmCvEleme()
        {
            InitializeComponent();
        }

        public static int record;
        GetirBasvuru2 basvuru = new GetirBasvuru2();

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
        dbIsTakipEntities db = new dbIsTakipEntities();

        private void frmCvEleme_Load(object sender, EventArgs e)
        {
            record = 1;
            lbl_Id.Visible = false;

            basvuru = YazilimKoyu_Ecom.Helper.CvHelper.Getir(record);

            KayıtlarıGetir(basvuru);

            webBrowser1.Navigate("https://www.cvmaker.com.tr/storage/CV-Ornekleri-Ogretmen.jpg");

        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelControl7_Click_1(object sender, EventArgs e)
        {

        }

        private void vGridControl7_Click(object sender, EventArgs e)
        {

        }

        private void btn_Previus_Click(object sender, EventArgs e)
        {
            if (record == 1)
            {
                MessageBox.Show("Zaten ilk kaydı görüntülüyorsunuz");
            }
            else
            {
                record = record -1;

                GetirBasvuru2 basvuru = new GetirBasvuru2();

                basvuru = YazilimKoyu_Ecom.Helper.CvHelper.Getir(record);

                KayıtlarıGetir(basvuru);
            }

        }

        public void KayıtlarıGetir(GetirBasvuru2 basvuru)
        {
            lbl_Id.Text = Convert.ToString(basvuru.Id);
            lbl_AdSoyad.Text = basvuru.your_name;
            txtAciklama.Text = basvuru.basvuru_detaylari;
            lblBolum.Text= basvuru.bolum;
            lblDerece.Text= basvuru.lisans_onlisans;
            lblDurum.Text = basvuru.mezun_sinif;
            lblMail.Text = basvuru.your_email;
            lblSehir.Text = basvuru.ikamet_sehri;
            lblUni.Text = basvuru.okul;
            lblBolum.Text= basvuru.bolum;
            lblTelefon.Text=Convert.ToString(basvuru.telefon_no);
            lblYabanciDiller.Text=Convert.ToString(basvuru.ngilizcesev);
            txtBildigiYazilimDilleri.Text = Convert.ToString(basvuru.yazilimdilleri);
            txtLinkdln.Text=basvuru.linkedinurl;



        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (record == YazilimKoyu_Ecom.Helper.CvHelper.GetTotalCount())
            {
                MessageBox.Show("Şuanda son başvuruyu görüntülüyorsunuz");
            }
            else
            {
                record = record +1;

                GetirBasvuru2 basvuru = new GetirBasvuru2();

                basvuru = YazilimKoyu_Ecom.Helper.CvHelper.Getir(record);

                KayıtlarıGetir(basvuru);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lbl_Id.Text) !=0)
            {
                int sonuc = YazilimKoyu_Ecom.Helper.CvHelper.Isaretle(Convert.ToInt32(lbl_Id.Text), 1);

                if (sonuc == 1)
                {
                    btn_Next_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Hata");
                }
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(lbl_Id.Text) !=0)
            {
                int sonuc = YazilimKoyu_Ecom.Helper.CvHelper.Isaretle(Convert.ToInt32(lbl_Id.Text), 0);

                if (sonuc == 1)
                {
                    btn_Next_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Hata");
                }
            }
        }

        private void lbl_AdSoyad_Click(object sender, EventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        private void labelControl8_Click(object sender, EventArgs e)
        {

        }
    }
}
