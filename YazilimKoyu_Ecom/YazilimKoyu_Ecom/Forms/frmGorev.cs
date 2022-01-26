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
    public partial class frmGorev : Form
    {
        public frmGorev()
        {
            InitializeComponent();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
        

        dbIsTakipEntities db = new dbIsTakipEntities();  
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            /* TblGorevler tblGorevler = new TblGorevler();
            tblGorevler.Aciklama =txtAciklama.Text;
           
            tblGorevler.Tarih=txtTarih.DateTime;
            tblGorevler.GorevVeren= int.Parse(txtGorevVeren.Text);
            db.TblGorevler.Add(tblGorevler);    
            db.SaveChanges(); buraya daha sonra bakılacak. */
            
            

        }
    }
}
