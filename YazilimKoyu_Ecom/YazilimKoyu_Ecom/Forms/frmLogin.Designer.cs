namespace YazilimKoyu_Ecom.Forms
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.btnPersonelGiris = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdmin = new DevExpress.XtraEditors.SimpleButton();
            this.txtSifre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(941, 276);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Properties.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.txtKullaniciAdi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.8F);
            this.txtKullaniciAdi.Properties.Appearance.Options.UseBackColor = true;
            this.txtKullaniciAdi.Properties.Appearance.Options.UseFont = true;
            this.txtKullaniciAdi.Size = new System.Drawing.Size(207, 32);
            this.txtKullaniciAdi.TabIndex = 29;
            this.txtKullaniciAdi.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(847, 276);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Black;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(79, 36);
            this.pictureEdit1.TabIndex = 25;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.BackgroundImage = global::YazilimKoyu_Ecom.Properties.Resources.Kodlama_Teknolojik_Okur_Yazarlik;
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(848, 327);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Black;
            this.pictureEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.Appearance.Options.UseForeColor = true;
            this.pictureEdit2.Properties.PictureAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit2.Size = new System.Drawing.Size(79, 36);
            this.pictureEdit2.TabIndex = 26;
            // 
            // btnPersonelGiris
            // 
            this.btnPersonelGiris.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.btnPersonelGiris.Appearance.ForeColor = System.Drawing.Color.SkyBlue;
            this.btnPersonelGiris.Appearance.Options.UseFont = true;
            this.btnPersonelGiris.Appearance.Options.UseForeColor = true;
            this.btnPersonelGiris.BackgroundImage = global::YazilimKoyu_Ecom.Properties.Resources.Kodlama_Teknolojik_Okur_Yazarlik;
            this.btnPersonelGiris.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonelGiris.ImageOptions.Image")));
            this.btnPersonelGiris.Location = new System.Drawing.Point(961, 390);
            this.btnPersonelGiris.Name = "btnPersonelGiris";
            this.btnPersonelGiris.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnPersonelGiris.Size = new System.Drawing.Size(187, 36);
            this.btnPersonelGiris.TabIndex = 23;
            this.btnPersonelGiris.Text = "GİRİŞ";
            this.btnPersonelGiris.Click += new System.EventHandler(this.btnPersonelGiris_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.btnAdmin.Appearance.ForeColor = System.Drawing.Color.SkyBlue;
            this.btnAdmin.Appearance.Options.UseFont = true;
            this.btnAdmin.Appearance.Options.UseForeColor = true;
            this.btnAdmin.BackgroundImage = global::YazilimKoyu_Ecom.Properties.Resources.Kodlama_Teknolojik_Okur_Yazarlik;
            this.btnAdmin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmin.ImageOptions.Image")));
            this.btnAdmin.Location = new System.Drawing.Point(961, 437);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnAdmin.Size = new System.Drawing.Size(187, 36);
            this.btnAdmin.TabIndex = 24;
            this.btnAdmin.Text = "ADMIN GİRİŞİ";
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(941, 330);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Properties.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.txtSifre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.8F);
            this.txtSifre.Properties.Appearance.Options.UseBackColor = true;
            this.txtSifre.Properties.Appearance.Options.UseFont = true;
            this.txtSifre.Size = new System.Drawing.Size(207, 32);
            this.txtSifre.TabIndex = 30;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Palace Script MT", 30.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.Info;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("labelControl3.ImageOptions.Image")));
            this.labelControl3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelControl3.Location = new System.Drawing.Point(1058, 545);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(97, 46);
            this.labelControl3.TabIndex = 33;
            this.labelControl3.Text = "artuvan";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1167, 603);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.btnPersonelGiris);
            this.Controls.Add(this.btnAdmin);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yazılım Köyü & Ecompw İş Takip       V 2.1.2";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtKullaniciAdi;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.SimpleButton btnPersonelGiris;
        private DevExpress.XtraEditors.SimpleButton btnAdmin;
        private DevExpress.XtraEditors.TextEdit txtSifre;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}