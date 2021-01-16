
namespace notUygulaması
{
    partial class GirisYap
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisYap));
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblYeniKayit = new System.Windows.Forms.Label();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.panelAlt1 = new System.Windows.Forms.Panel();
            this.panelAlt2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKucult = new System.Windows.Forms.Button();
            this.checkBoxSifreGoster = new System.Windows.Forms.CheckBox();
            this.btnKapat = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.icon2 = new System.Windows.Forms.PictureBox();
            this.icon1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.SystemColors.Control;
            this.txtKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(121, 181);
            this.txtKullaniciAdi.Multiline = true;
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(143, 18);
            this.txtKullaniciAdi.TabIndex = 13;
            this.txtKullaniciAdi.Text = "Kullanıcı Adı";
            this.txtKullaniciAdi.Click += new System.EventHandler(this.txtKullaniciAdi_Click);
            this.txtKullaniciAdi.Leave += new System.EventHandler(this.txtKullaniciAdi_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(95, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Yeni Öğretmen:";
            // 
            // lblYeniKayit
            // 
            this.lblYeniKayit.AutoSize = true;
            this.lblYeniKayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblYeniKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYeniKayit.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblYeniKayit.Location = new System.Drawing.Point(206, 373);
            this.lblYeniKayit.Name = "lblYeniKayit";
            this.lblYeniKayit.Size = new System.Drawing.Size(56, 16);
            this.lblYeniKayit.TabIndex = 16;
            this.lblYeniKayit.Text = "Oluştur";
            this.lblYeniKayit.Click += new System.EventHandler(this.label_click);
            this.lblYeniKayit.MouseLeave += new System.EventHandler(this.mouse_uzerinden_cekilince);
            this.lblYeniKayit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_uzerine_gelince);
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.Color.SlateBlue;
            this.btnGirisYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGirisYap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnGirisYap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnGirisYap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGirisYap.Location = new System.Drawing.Point(192, 320);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(82, 37);
            this.btnGirisYap.TabIndex = 14;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.SystemColors.Control;
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSifre.Location = new System.Drawing.Point(121, 241);
            this.txtSifre.Multiline = true;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(141, 24);
            this.txtSifre.TabIndex = 19;
            this.txtSifre.Text = "Password";
            this.txtSifre.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSifre_MouseClick);
            this.txtSifre.Leave += new System.EventHandler(this.txtSifre_Leave);
            // 
            // panelAlt1
            // 
            this.panelAlt1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelAlt1.Location = new System.Drawing.Point(89, 206);
            this.panelAlt1.Name = "panelAlt1";
            this.panelAlt1.Size = new System.Drawing.Size(175, 2);
            this.panelAlt1.TabIndex = 20;
            // 
            // panelAlt2
            // 
            this.panelAlt2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelAlt2.Location = new System.Drawing.Point(89, 267);
            this.panelAlt2.Name = "panelAlt2";
            this.panelAlt2.Size = new System.Drawing.Size(175, 2);
            this.panelAlt2.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnKucult);
            this.panel1.Controls.Add(this.checkBoxSifreGoster);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.icon2);
            this.panel1.Controls.Add(this.panelAlt2);
            this.panel1.Controls.Add(this.txtKullaniciAdi);
            this.panel1.Controls.Add(this.panelAlt1);
            this.panel1.Controls.Add(this.btnGirisYap);
            this.panel1.Controls.Add(this.txtSifre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.icon1);
            this.panel1.Controls.Add(this.lblYeniKayit);
            this.panel1.Location = new System.Drawing.Point(364, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 452);
            this.panel1.TabIndex = 22;
            // 
            // btnKucult
            // 
            this.btnKucult.BackColor = System.Drawing.Color.White;
            this.btnKucult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKucult.Font = new System.Drawing.Font("Wide Latin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKucult.ForeColor = System.Drawing.Color.Black;
            this.btnKucult.Location = new System.Drawing.Point(305, 2);
            this.btnKucult.Name = "btnKucult";
            this.btnKucult.Size = new System.Drawing.Size(35, 28);
            this.btnKucult.TabIndex = 23;
            this.btnKucult.Text = "-";
            this.btnKucult.UseVisualStyleBackColor = false;
            this.btnKucult.Click += new System.EventHandler(this.btnKucult_Click);
            // 
            // checkBoxSifreGoster
            // 
            this.checkBoxSifreGoster.AutoSize = true;
            this.checkBoxSifreGoster.Location = new System.Drawing.Point(174, 275);
            this.checkBoxSifreGoster.Name = "checkBoxSifreGoster";
            this.checkBoxSifreGoster.Size = new System.Drawing.Size(88, 17);
            this.checkBoxSifreGoster.TabIndex = 22;
            this.checkBoxSifreGoster.Text = "Şifreyi Göster";
            this.checkBoxSifreGoster.UseVisualStyleBackColor = true;
            this.checkBoxSifreGoster.CheckedChanged += new System.EventHandler(this.checkBoxSifreGoster_CheckedChanged);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.White;
            this.btnKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKapat.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKapat.ForeColor = System.Drawing.Color.Black;
            this.btnKapat.Location = new System.Drawing.Point(702, 0);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(35, 28);
            this.btnKapat.TabIndex = 22;
            this.btnKapat.Text = "X";
            this.btnKapat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            this.btnKapat.MouseLeave += new System.EventHandler(this.btnKapat_MouseLeave);
            this.btnKapat.MouseHover += new System.EventHandler(this.btnKapat_MouseHover);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::notUygulaması.Properties.Resources.user1;
            this.pictureBox3.Location = new System.Drawing.Point(126, 43);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(109, 96);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // icon2
            // 
            this.icon2.BackColor = System.Drawing.Color.Transparent;
            this.icon2.BackgroundImage = global::notUygulaması.Properties.Resources.txt;
            this.icon2.ErrorImage = global::notUygulaması.Properties.Resources.kullanici;
            this.icon2.Image = global::notUygulaması.Properties.Resources.password;
            this.icon2.Location = new System.Drawing.Point(86, 237);
            this.icon2.Name = "icon2";
            this.icon2.Size = new System.Drawing.Size(32, 32);
            this.icon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon2.TabIndex = 18;
            this.icon2.TabStop = false;
            // 
            // icon1
            // 
            this.icon1.BackColor = System.Drawing.Color.Transparent;
            this.icon1.BackgroundImage = global::notUygulaması.Properties.Resources.txt;
            this.icon1.ErrorImage = global::notUygulaması.Properties.Resources.kullanici;
            this.icon1.Image = global::notUygulaması.Properties.Resources.kullanici;
            this.icon1.Location = new System.Drawing.Point(85, 174);
            this.icon1.Name = "icon1";
            this.icon1.Size = new System.Drawing.Size(32, 32);
            this.icon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon1.TabIndex = 17;
            this.icon1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::notUygulaması.Properties.Resources.giris;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(485, 452);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // GirisYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(736, 450);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GirisYap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Adı";
             this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblYeniKayit;
        private System.Windows.Forms.PictureBox icon1;
        private System.Windows.Forms.PictureBox icon2;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Panel panelAlt1;
        private System.Windows.Forms.Panel panelAlt2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.CheckBox checkBoxSifreGoster;
        private System.Windows.Forms.Button btnKucult;
    }
}

