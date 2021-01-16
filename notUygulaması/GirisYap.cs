using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace notUygulaması
{
    public partial class GirisYap : Form
    {
        public GirisYap()
        {
            InitializeComponent();

            //txtPassword.PasswordChar = '*';
        }

        private void label_click(object sender, EventArgs e)
        {
            YeniKayit yk = new YeniKayit();
            yk.Show();
            this.Hide();
        }

        private void mouse_uzerine_gelince(object sender, MouseEventArgs e)
        {
            lblYeniKayit.ForeColor = Color.Red;
        }

        private void mouse_uzerinden_cekilince(object sender, EventArgs e)
        {
            lblYeniKayit.ForeColor = Color.MediumSlateBlue;
        }

        private void txtKullaniciAdi_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "Kullanıcı Adı")
            {
                txtKullaniciAdi.Text = "";
            }
                panelAlt1.BackColor = Color.SteelBlue;
                txtKullaniciAdi.ForeColor = Color.SteelBlue;

                panelAlt2.BackColor = Color.Black;
                txtSifre.ForeColor = Color.Black;
            
        }

        private void txtSifre_MouseClick(object sender, MouseEventArgs e)
        {
            txtSifre.Text = "";

            panelAlt2.BackColor = Color.SteelBlue;
            txtSifre.ForeColor = Color.SteelBlue;

            panelAlt1.BackColor = Color.Black;
            txtKullaniciAdi.ForeColor = Color.Black;
        }
         private void txtKullaniciAdi_Leave(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "")
            {
                txtKullaniciAdi.Text = "Kullanıcı Adı";
            }
        }

        private void txtSifre_Leave(object sender, EventArgs e)
        {
            if (txtSifre.Text == "")
            {
                txtSifre.Text = "Password";
            }
        }

        private void btnKapat_MouseHover(object sender, EventArgs e)
        {
            btnKapat.BackColor = Color.Red;
            btnKapat.ForeColor = Color.White;
        }

        private void btnKapat_MouseLeave(object sender, EventArgs e)
        {
            btnKapat.BackColor = Color.White;
            btnKapat.ForeColor = Color.Black;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void checkBoxSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSifreGoster.Checked == true)
            {
                txtSifre.UseSystemPasswordChar = true;
            }
            else
            {
                txtSifre.UseSystemPasswordChar = false;
            }
        }
     
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtKullaniciAdi.Text) &&
               !string.IsNullOrEmpty(txtSifre.Text) && 
               !txtKullaniciAdi.Text.Equals("Kullanıcı Adı") &&
               !txtSifre.Text.Equals("Password"))
            {
                VeriTabani vt = new VeriTabani();

                string kullaniciAdi = txtKullaniciAdi.Text;
                string kullaniciSifre = txtSifre.Text;

                /*SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-1LCVNV4\SQLEXPRESS;Initial Catalog=okul;Integrated Security=True");
                SqlDataAdapter sqa = new SqlDataAdapter("SELECT count(*) FROM ogretmenler WHERE ogretmen_kullanici_ad = '" + txtKullaniciAdi.Text + "' AND ogretmen_sifre = '" + txtSifre.Text + "'", baglanti);
                DataTable dt = new DataTable();
                sqa.Fill(dt);*/
                DataTable table = new DataTable();
                SqlDataAdapter sqa = new SqlDataAdapter();

                SqlCommand sorgu = new SqlCommand("SELECT * FROM ogretmenler WHERE ogretmen_kullanici_ad = @kullaniciAdi AND ogretmen_sifre = @sifre", vt.GetConnection());

                sorgu.Parameters.Add("@kullaniciAdi", SqlDbType.VarChar).Value=kullaniciAdi;
                sorgu.Parameters.Add("@sifre", SqlDbType.VarChar).Value=kullaniciSifre;

                sqa.SelectCommand = sorgu;
                sqa.Fill(table);
                
                if(table.Rows.Count > 0)
                {
                    this.Hide();
                    IslemMenu im = new IslemMenu();
                    im.Show();                  
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş Lütfen Tekrar Deneyin...", "UYARI!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                /*DataTable dt = new DataTable();
                sqa.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    IslemMenu im = new IslemMenu();
                    im.Show();
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş Lütfen Tekrar Deneyin...", "UYARI!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }*/
            }
            else
            {
                MessageBox.Show("Lütfen Tüm Boşlukları Kontrol Edin!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtKullaniciAdi.Select();
            }           
        }

    }
}
