using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace notUygulaması
{
    public partial class YeniKayit : Form
    {
        public YeniKayit()
        {
            InitializeComponent();
        }

        private void btnKapatKayit_MouseHover(object sender, EventArgs e)
        {
            btnKapatKayit.BackColor = Color.Red;
            btnKapatKayit.ForeColor = Color.White;
        }

        private void btnKapatKayit_MouseLeave(object sender, EventArgs e)
        {
            btnKapatKayit.BackColor = Color.Transparent;
            btnKapatKayit.ForeColor = Color.Black;
        }

        private void btnKapatKayit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblGeri_Click(object sender, EventArgs e)
        {
            GirisYap gy = new GirisYap();
            gy.Show();
            this.Hide();
        }

        private void lblGeri_MouseHover(object sender, EventArgs e)
        {
            lblGeri.ForeColor = Color.Red;
        }

        private void lblGeri_MouseLeave(object sender, EventArgs e)
        {
            lblGeri.ForeColor = Color.Black;
        }

        private void txtAd_Click(object sender, EventArgs e)
        {
            paneYAlt1.BackColor = Color.Red;
            panelYAlt2.BackColor = Color.Black;
            panelYAlt3.BackColor = Color.Black;
            panelYAlt5.BackColor = Color.Black;
            panelYAlt6.BackColor = Color.Black;
            panelYAlt8.BackColor = Color.Black;
            panelYAlt9.BackColor = Color.Black;
            txtAd.ForeColor = Color.Black;
        }

        private void txtAd_Leave(object sender, EventArgs e)
        {
            paneYAlt1.BackColor = Color.Black;
            txtAd.ForeColor = Color.DarkGray;
        }

        private void txtSoyAd_Click(object sender, EventArgs e)
        {
            paneYAlt1.BackColor = Color.Black;
            panelYAlt2.BackColor = Color.Red;
            panelYAlt3.BackColor = Color.Black;
            panelYAlt5.BackColor = Color.Black;
            panelYAlt6.BackColor = Color.Black;
            panelYAlt8.BackColor = Color.Black;
            panelYAlt9.BackColor = Color.Black;
            txtSoyAd.ForeColor = Color.Black;

        }

        private void txtSoyAd_Leave(object sender, EventArgs e)
        {
            panelYAlt2.BackColor = Color.Black;
            txtSoyAd.ForeColor = Color.DarkGray;
        }

        private void txtKullaniciAdi_Click(object sender, EventArgs e)
        {
            paneYAlt1.BackColor = Color.Black;
            panelYAlt2.BackColor = Color.Black;
            panelYAlt3.BackColor = Color.Red;
            panelYAlt5.BackColor = Color.Black;
            panelYAlt6.BackColor = Color.Black;
            panelYAlt8.BackColor = Color.Black;
            panelYAlt9.BackColor = Color.Black;
            txtKullaniciAdi.ForeColor = Color.Black;
        }

        private void txtKullaniciAdi_Leave(object sender, EventArgs e)
        {
            panelYAlt3.BackColor = Color.Black;
            txtKullaniciAdi.ForeColor = Color.DarkGray;
        }

        private void txtMail_Click(object sender, EventArgs e)
        {
            paneYAlt1.BackColor = Color.Black;
            panelYAlt2.BackColor = Color.Black;
            panelYAlt3.BackColor = Color.Black;
            panelYAlt5.BackColor = Color.Red;
            panelYAlt6.BackColor = Color.Black;
            panelYAlt8.BackColor = Color.Black;
            panelYAlt9.BackColor = Color.Black;
            txtMail.ForeColor = Color.Black;
        }

        private void txtMail_Leave(object sender, EventArgs e)
        {
            panelYAlt5.BackColor = Color.Black;
            txtMail.ForeColor = Color.DarkGray;

            string mailDuzeni = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(txtMail.Text, mailDuzeni)) { errorProvider1.Clear(); }
            else
            {
                txtMail.Focus();
                errorProvider1.SetError(txtMail, "Lütfen Geçerli Bir Mail Adresi Girin!");
            }
        }

        private void txtTelefon_Click(object sender, EventArgs e)
        {
            paneYAlt1.BackColor = Color.Black;
            panelYAlt2.BackColor = Color.Black;
            panelYAlt3.BackColor = Color.Black;
            panelYAlt5.BackColor = Color.Black;
            panelYAlt6.BackColor = Color.Red;
            panelYAlt8.BackColor = Color.Black;
            panelYAlt9.BackColor = Color.Black;
            txtTelefon.ForeColor = Color.Black;
        }

        private void txtTelefon_Leave(object sender, EventArgs e)
        {
            panelYAlt6.BackColor = Color.Black;
            txtTelefon.ForeColor = Color.DarkGray;
            if (txtTelefon.TextLength == 11)
            {
                errorProvider1.Clear();
            }
            else
            {
                txtTelefon.Focus();
                errorProvider1.SetError(txtTelefon, "Lütfen Numaranızı Kontrol Edin!");
            }
        }

        private void txtSifre_Click(object sender, EventArgs e)
        {
            paneYAlt1.BackColor = Color.Black;
            panelYAlt2.BackColor = Color.Black;
            panelYAlt3.BackColor = Color.Black;
            panelYAlt5.BackColor = Color.Black;
            panelYAlt6.BackColor = Color.Black;
            panelYAlt8.BackColor = Color.Red;
            panelYAlt9.BackColor = Color.Black;
            txtSifre.ForeColor = Color.Black;
        }

        private void txtSifre_Leave(object sender, EventArgs e)
        {
            panelYAlt8.BackColor = Color.Black;
            txtSifre.ForeColor = Color.DarkGray;
        }

        private void txtSifreTekrar_Click(object sender, EventArgs e)
        {
            paneYAlt1.BackColor = Color.Black;
            panelYAlt2.BackColor = Color.Black;
            panelYAlt3.BackColor = Color.Black;
            panelYAlt5.BackColor = Color.Black;
            panelYAlt6.BackColor = Color.Black;
            panelYAlt8.BackColor = Color.Black;
            panelYAlt9.BackColor = Color.Red;
            txtSifreTekrar.ForeColor = Color.Black;
        }

        private void txtSifreTekrar_Leave(object sender, EventArgs e)
        {
            panelYAlt9.BackColor = Color.Black;
            txtSifreTekrar.ForeColor = Color.DarkGray;
        }

        private void txtSoyAd_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSoyAd.Text))
            {
                e.Cancel = true;
                txtSoyAd.Focus();
                errorProvider1.SetError(txtSoyAd, "Lütfen Soy Adınızı Girin!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtSoyAd, null);
            }
        }

        private void txtKullaniciAdi_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtKullaniciAdi.Text))
            {
                e.Cancel = true;
                txtKullaniciAdi.Focus();
                errorProvider1.SetError(txtKullaniciAdi, "Lütfen Kullanıcı Adını Girin!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtKullaniciAdi, null);
            }

            if (kullaniciKontrol())
            {
                MessageBox.Show("Kullanıcı Adı Sisteme Daha önce Kayıt Edilmiştir Lütfen Farklı Ber Kullanıcı Adı Seçin");
            }
        }

        private void txtMail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtMail.Text))
            {
                e.Cancel = true;
                txtMail.Focus();
                errorProvider1.SetError(txtMail, "Lütfen Mail Adresini Girin!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtMail, null);
            }
        }

        private void txtTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTelefon.Text))
            {
                e.Cancel = true;
                txtTelefon.Focus();
                errorProvider1.SetError(txtTelefon, "Lütfen Telefon Numaranızı Girin!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtTelefon, null);
            }
            // if (txtTelefon.Text < 11)
            {

            }
        }

        private void txtSifre_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSifre.Text))
            {
                e.Cancel = true;
                txtSifre.Focus();
                errorProvider1.SetError(txtSifre, "Lütfen Adınızı Girin!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtSifre, null);
            }
        }

        private void txtSifreTekrar_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSifreTekrar.Text))
            {
                e.Cancel = true;
                txtSifreTekrar.Focus();
                errorProvider1.SetError(txtSifreTekrar, "Lütfen Tekrar Şifreyi Girin!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtSifreTekrar, null);
            }
        }

        private void txtAd_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAd.Text))
            {
                e.Cancel = true;
                txtAd.Focus();
                errorProvider1.SetError(txtAd, "Lütfen Adınızı Girin!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAd, null);
            }
        }

        private void cbBransSecim_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cbBransSecim.Text))
            {
                e.Cancel = true;
                cbBransSecim.Focus();
                errorProvider1.SetError(cbBransSecim, "Lütfen Branşınızı Seçin!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cbBransSecim, null);
            }
        }

        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char karakter = e.KeyChar;
            if (!Char.IsDigit(karakter) && karakter != 8)
            {
                e.Handled = true;
                MessageBox.Show("Lütfen Girdiğiniz Karakteri Kontrol Edin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (!txtSifre.Text.Equals(txtSifreTekrar.Text))
                {
                    MessageBox.Show("Şifreler Eşleşmitor Lütfen Kontrol Edip Tekrar Deneyin...", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    kayitEkle();
                }
            }
        }

        void kayitEkle()
        {
            if (pbResim.Image != null)
            {
                VeriTabani vt = new VeriTabani();
                
                SqlCommand eklemeSorgu = new SqlCommand("INSERT INTO ogretmenler (ogretmen_ad, ogretmen_soyad, " +
                    "ogretmen_kullanici_ad, ogretmen_brans, ogretmen_email, " +
                    "ogretmen_telefon, ogretmen_cinsiyet, ogretmen_resim, " +
                    "ogretmen_sifre) VALUES(@ad, @soyAd, @kullaniciAdi, @brans, @email, @telefon, @cinsiyet, @resim, @sifre)", vt.GetConnection());


                MemoryStream mStream = new MemoryStream();
                pbResim.Image.Save(mStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] resimSecim = mStream.ToArray();
                eklemeSorgu.Parameters.Add("@ad", SqlDbType.VarChar).Value=txtAd.Text;
                eklemeSorgu.Parameters.Add("@soyAd", SqlDbType.VarChar).Value = txtSoyAd.Text;
                eklemeSorgu.Parameters.Add("@kullaniciAdi", SqlDbType.VarChar).Value = txtKullaniciAdi.Text;
                eklemeSorgu.Parameters.Add("@brans", SqlDbType.VarChar).Value = cbBransSecim.Text;
                eklemeSorgu.Parameters.Add("@email", SqlDbType.VarChar).Value = txtMail.Text;
                eklemeSorgu.Parameters.Add("@telefon", SqlDbType.VarChar).Value = txtTelefon.Text;

                if (rbErkek.Checked)
                {
                    eklemeSorgu.Parameters.Add("@cinsiyet", SqlDbType.VarChar).Value = "Erkek";
                }
                else if (rbKadin.Checked)
                {
                    eklemeSorgu.Parameters.Add("@cinsiyet", SqlDbType.VarChar).Value = "Kadın";
                }
                else
                {
                    eklemeSorgu.Parameters.Add("@cinsiyet", SqlDbType.VarChar).Value = "Belirsiz";
                }
                eklemeSorgu.Parameters.Add("@resim", SqlDbType.Image).Value = resimSecim;
                eklemeSorgu.Parameters.Add("@sifre", SqlDbType.VarChar).Value = txtSifre.Text;
                
                vt.baglantiyiAc();

                try
                {
                    if (DialogResult.OK == MessageBox.Show("Kayıt İşlemi Başarıyla Gerçekleşti", "Tebrikler...", MessageBoxButtons.OK))
                    {
                        eklemeSorgu.ExecuteNonQuery();
                        GirisYap gy = new GirisYap();
                        gy.Show();
                        this.Hide();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Kayıt Sırasında bir Hata Gerçekleşti", e.Message);
                }
                vt.baglantiyiKapat();
            }
            else
            {
                MessageBox.Show("Lütfen Bir Resim Seçin", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dosyaAc()
        {
            Stream myStream = null;
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter ="Image File(*.jpe; *.jpeg; *.png; *.bmp) | *.jpg;*.jpeg;*.png; *.bmp";
            if (opf.ShowDialog(this) == DialogResult.OK) {
                try
                {
                    if((myStream = opf.OpenFile()) != null)
                    {
                        string dosyaAdi = opf.FileName;
                        lblDosyaAdi.Text = dosyaAdi;
                        
                        if(myStream.Length > 512000)
                        {
                            MessageBox.Show("Dosyanın Boyutu Çok Büyük");
                        }
                        else
                        {
                            pbResim.Load(dosyaAdi);
                        }
                    }
                }
                catch ( Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            dosyaAc();
        }

        public Boolean kullaniciKontrol()
        {
            VeriTabani vt = new VeriTabani();

            string kullaniciAdi = txtKullaniciAdi.Text;

            DataTable table = new DataTable();
            SqlDataAdapter sqa = new SqlDataAdapter();

            SqlCommand sorgu = new SqlCommand("SELECT * FROM ogretmenler WHERE ogretmen_kullanici_ad = @kullaniciAdi", vt.GetConnection());

            sorgu.Parameters.Add("@kullaniciAdi", SqlDbType.VarChar).Value = kullaniciAdi;

            sqa.SelectCommand = sorgu;
            sqa.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}