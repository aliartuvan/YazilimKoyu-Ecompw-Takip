using DevExpress.XtraEditors;
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
    public partial class frmDepartmanlar : Form
    {

        dbIsTakipEntities db = new dbIsTakipEntities();
        public frmDepartmanlar()
        {
            InitializeComponent();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            TblDepartmanlar t = new TblDepartmanlar();
            t.Ad = txtAd.Text;
            db.TblDepartmanlar.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Departman sisteme eklendi.", "Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            List();

            

        }

        void List() 
        { 
        

            var values = (from x in db.TblDepartmanlar select new { 
            
            x.id,
            x.Ad
            }).ToList();


            gridControl1.DataSource=values;
        
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtId.Text);
            var y = db.TblDepartmanlar.Find(x);
            db.TblDepartmanlar.Remove(y);
            db.SaveChanges();
            XtraMessageBox.Show("Departman sistemden silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            List();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void frmDepartmanlar_Load(object sender, EventArgs e)
        {

        }
    }
}
