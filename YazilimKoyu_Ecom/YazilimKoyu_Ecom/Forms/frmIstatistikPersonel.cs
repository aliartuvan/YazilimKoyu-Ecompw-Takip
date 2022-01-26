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
    public partial class frmIstatistikPersonel : Form
    {
        public frmIstatistikPersonel()
        {
            InitializeComponent();
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void panelControl9_Paint(object sender, PaintEventArgs e)
        {

        }

        dbIsTakipEntities db = new dbIsTakipEntities();     
        private void frmIstatistikPersonel_Load(object sender, EventArgs e)
        {
            lblToplamDepartman.Text =  db.TblDepartmanlar.Count().ToString();
            lblToplamFirma.Text= db.TblFirmalar.Count().ToString(); 
            lblToplamPersonel.Text= db.TblPersonel.Count().ToString();  
            lblAktifIs.Text=db.TblGorevler.Count(x => x.Durum=="1").ToString();
            lblPasifIs.Text=db.TblGorevler.Count(x => x.Durum=="0").ToString();
            lblSonGorev.Text=db.TblGorevler.OrderByDescending(x => x.id).Select(x => x.Aciklama).FirstOrDefault();
            lblSektor.Text=db.TblFirmalar.Select(x=>x.Sektör).Distinct().Count().ToString();
            lblSehirSayisi.Text=db.TblFirmalar.Select(x=>x.il).Distinct().Count().ToString();   
            DateTime bugun = DateTime.Today;
            lblBugunGorevi.Text=db.TblGorevler.Count(x=>x.Tarih==bugun).ToString();
            
            




        }

        private void labelControl8_Click(object sender, EventArgs e)
        {

        }

        private void labelControl16_Click(object sender, EventArgs e)
        {

        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void panelControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl9_Click(object sender, EventArgs e)
        {

        }

        private void labelControl20_Click(object sender, EventArgs e)
        {

        }
    }
}
