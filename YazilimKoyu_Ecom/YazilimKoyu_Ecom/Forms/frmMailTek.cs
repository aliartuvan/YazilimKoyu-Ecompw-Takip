using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using DevExpress.XtraEditors;

namespace YazilimKoyu_Ecom.Forms
{
    public partial class frmMailTek : Form
    {
        public frmMailTek()
        {
            InitializeComponent();
        }

        private void btnMailGonder_Click(object sender, EventArgs e)
        {
            MailMessage message = new MailMessage();
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Credentials=new System.Net.NetworkCredential("/*mail gelmeli*/", "/*şifre gelmeli*/");
            smtpClient.Port =587;
            smtpClient.Host = "smtp.yandex.com.tr";
            smtpClient.EnableSsl = true;
            message.To.Add(txtAlici.Text);
            message.From= new MailAddress("/*mail*/");
            message.Subject= (txtBaslik.Text);
            message.Body= (txtIcerik.Text);
            smtpClient.Send(message);



        }

        private void frmMailTek_Load(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Gönderdiğiniz maillerde mail adresinin doğruluğunu kontrol ediniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
