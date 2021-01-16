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

namespace notUygulaması
{
    public partial class IslemMenu : Form
    {
        int mov;
        int movY;
        int movX;

        public IslemMenu()
        {
            InitializeComponent();
        }


        private void IslemMenu_Load(object sender, EventArgs e)
        {
            cbOBransSecim.SelectedIndex = 0;
            panelGiris.Visible = false;
            panelKayitlariListele.Visible = false;
        }

        private void panelUst_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panelUst_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panelUst_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void pbKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbSimge_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFlatOturumKapat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkış Yapmak İstediğinize Eminmisiniz!!","ttt" , MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                GirisYap gy = new GirisYap();
                gy.Show();
                this.Hide();
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnBunGiris_Click(object sender, EventArgs e)
        {
            panelGiris.Visible = false;
            panelKayitlariListele.Visible = false;
        }

        private void btnBunKayitEkle_Click(object sender, EventArgs e)
        {
            panelGiris.Visible = true;
            panelKayitlariListele.Visible = false;
        }

        private void btnBunKayitListele_Click(object sender, EventArgs e)
        {
            panelGiris.Visible = false;
            panelKayitlariListele.Visible = true;
            listele();
            ogrTemizle();
        }

        private void txtONot1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char karakter = e.KeyChar;
            if (!Char.IsDigit(karakter) && karakter != 8)
            {
                e.Handled = true;
                MessageBox.Show("Lütfen Girdiğiniz Karakteri Kontrol Edin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtONot2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char karakter = e.KeyChar;
            if (!Char.IsDigit(karakter) && karakter != 8)
            {
                e.Handled = true;
                MessageBox.Show("Lütfen Girdiğiniz Karakteri Kontrol Edin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtONumara_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char karakter = e.KeyChar;
            if (!Char.IsDigit(karakter) && karakter != 8)
            {
                e.Handled = true;
                MessageBox.Show("Lütfen Girdiğiniz Karakteri Kontrol Edin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtONot1_Leave(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(txtVize.Text) <= 100 && int.Parse(txtVize.Text) >= 0)
                {
                    errorImProvider.Clear();
                }
                else
                {
                    txtVize.Focus();
                    errorImProvider.SetError(txtVize, "Lütfen Numaranızı Kontrol Edin!");
                }
            }
            catch (Exception ex) { }
        }

        private void txtONot2_Leave(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(txtFinal.Text) <= 100 && int.Parse(txtFinal.Text) >= 0)
                {
                    errorImProvider.Clear();
                }
                else
                {
                    txtFinal.Focus();
                    errorImProvider.SetError(txtFinal, "Lütfen Numaranızı Kontrol Edin!");
                }
            }
            catch (Exception ex) { }
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (txtOAd.Text == "" || txtOSoyad.Text == "" || txtONumara.Text == "" || txtVize.Text == "" || txtFinal.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Boşlukları Doldurunuz!!", "Boş Alanlar Var!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                kayitEkle();
            }
        }

        void kayitEkle()
        {
            VeriTabani vt = new VeriTabani();

            SqlCommand ogrenciEklemeSorgu = new SqlCommand("INSERT INTO ogrenciler (ogrenci_ad, ogrenci_soyad, " +
                "ogrenci_numara, ogrenci_vize, ogrenci_final, ogrenci_ort, ogrenci_brans)" +
                " VALUES(@oAd, @oSoyAd, @oNumura, @oVize, @oFinal, @oOrt, @oBrans)", vt.GetConnection());

            float vize = float.Parse(txtVize.Text), final = float.Parse(txtFinal.Text);
            float ort = (float)Math.Round(((vize * 0.4) + (final * 0.6)), 4);

            ogrenciEklemeSorgu.Parameters.Add("@oAd", SqlDbType.VarChar).Value = txtOAd.Text;
            ogrenciEklemeSorgu.Parameters.Add("@oSoyAd", SqlDbType.VarChar).Value = txtOSoyad.Text;
            ogrenciEklemeSorgu.Parameters.Add("@oNumura", SqlDbType.Int).Value = int.Parse(txtONumara.Text);
            ogrenciEklemeSorgu.Parameters.Add("@oVize", SqlDbType.Float).Value = vize;
            ogrenciEklemeSorgu.Parameters.Add("@oFinal", SqlDbType.Float).Value = final;
            ogrenciEklemeSorgu.Parameters.Add("@oOrt", SqlDbType.Float).Value = Math.Round(ort, 2);
            ogrenciEklemeSorgu.Parameters.Add("@oBrans", SqlDbType.VarChar).Value = cbOBransSecim.Text;

            vt.baglantiyiAc();
            if (ogrenciKontrol())
            {
                MessageBox.Show("Bu Kayıt Daha Önce Eklenmiştir");
            }
            else
            {
                ogrenciEklemeSorgu.ExecuteNonQuery();
                try
                {
                    if (DialogResult.OK == MessageBox.Show("Kayıt İşlemi Başarıyla Gerçekleşti", "Tebrikler...", MessageBoxButtons.OK))
                    {
                        temizle();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Kayıt Sırasında bir Hata Gerçekleşti", e.Message);
                }
                vt.baglantiyiKapat();
            }
        }

        void temizle()
        {
            txtOAd.Clear();
            txtOSoyad.Clear();
            txtONumara.Clear();
            txtVize.Clear();
            txtFinal.Clear();
            cbOBransSecim.SelectedIndex = 0;
        }

        void listele()
        {
            VeriTabani vt = new VeriTabani();
            vt.baglantiyiAc();

            SqlCommand listelemeSorgu = new SqlCommand("SELECT * FROM  ogrenciler ORDER BY  ogrenci_numara ASC", vt.GetConnection());
            try
            {
                SqlDataReader veriler = listelemeSorgu.ExecuteReader();

                listViewOgrenciBilgileri.Items.Clear();

                while (veriler.Read())
                {
                    ListViewItem tabloVerisi = new ListViewItem(veriler[3].ToString());
                    tabloVerisi.SubItems.Add(veriler[1].ToString());
                    tabloVerisi.SubItems.Add(veriler[2].ToString());
                    tabloVerisi.SubItems.Add(veriler[4].ToString());
                    tabloVerisi.SubItems.Add(veriler[5].ToString());
                    tabloVerisi.SubItems.Add(veriler[6].ToString());
                    // veriler.GetFloat(6).ToString();
                    tabloVerisi.SubItems.Add(veriler.GetString(7).ToString());

                    listViewOgrenciBilgileri.Items.Add(tabloVerisi);
                }
                veriler.Close();
                listelemeSorgu.Dispose();
                vt.baglantiyiKapat();
            }
            catch(Exception e)
            {}
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            listele();
            ogrTemizle();
        }

        public Boolean ogrenciKontrol()
        {
            VeriTabani vt = new VeriTabani();

            string ogrenciNo = txtONumara.Text;

            DataTable table = new DataTable();
            SqlDataAdapter sqa = new SqlDataAdapter();

            SqlCommand sorgu = new SqlCommand("SELECT * FROM ogrenciler WHERE ogrenci_numara = @ogrenciNumara", vt.GetConnection());

            sorgu.Parameters.Add("@ogrenciNumara", SqlDbType.VarChar).Value = ogrenciNo;

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
        private void listViewOgrenciBilgileri_MouseClick(object sender, MouseEventArgs e)
        {
            String ogrNumara = listViewOgrenciBilgileri.SelectedItems[0].SubItems[0].Text;
            String ogrAd = listViewOgrenciBilgileri.SelectedItems[0].SubItems[1].Text;
            String ogrSoyAd = listViewOgrenciBilgileri.SelectedItems[0].SubItems[2].Text;
            String ogrVizeNot = listViewOgrenciBilgileri.SelectedItems[0].SubItems[3].Text;
            String ogrFinalNot = listViewOgrenciBilgileri.SelectedItems[0].SubItems[4].Text;

            txtogrNumara.Text = ogrNumara;
            txtOgrAd.Text = ogrAd;
            txtOgrSoyAd.Text = ogrSoyAd;
            txtOgrVizeNot.Text = ogrVizeNot;
            txtOgrFinalNot.Text = ogrFinalNot;
        }

        private void btnOgrSil_Click(object sender, EventArgs e)
        {
            if (txtogrNumara.Text != "" || txtOgrAd.Text != "" || txtOgrSoyAd.Text != "" || txtOgrVizeNot.Text != "" || txtOgrFinalNot.Text != "")
            {
                DialogResult mesage = new DialogResult();
                mesage = MessageBox.Show("Kaydı Silmeye Eminmisiniz?", "Eminmisiniz!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (mesage == DialogResult.Yes)
                {
                    VeriTabani vt = new VeriTabani();
                    vt.baglantiyiAc();
                    try
                    {
                        SqlCommand silmeSorgu = new SqlCommand("DELETE FROM ogrenciler WHERE ogrenci_numara = @ogrNo", vt.GetConnection());
                        silmeSorgu.Parameters.AddWithValue("@ogrNo", int.Parse(txtogrNumara.Text));

                        silmeSorgu.ExecuteNonQuery();
                        MessageBox.Show("Kayıt Başarılı Bir Şekilde Silindi!");
                        ogrTemizle();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Silme Sırasında bir hata oluştu!");
                    }
                    vt.baglantiyiKapat();
                }
            }
            else
            {
                MessageBox.Show("Lütfen Seçim Yaptığınıza Yada Tüm Boşlukların Dolu Olduğuna Emin Olur!");
            }
        }

        void ogrTemizle()
        {
            txtogrNumara.Clear();
            txtOgrAd.Clear();
            txtOgrSoyAd.Clear();
            txtogrNumara.Clear();
            txtOgrVizeNot.Clear();
            txtOgrFinalNot.Clear();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            if (txtogrNumara.Text!="" || txtOgrAd.Text!="" || txtOgrSoyAd.Text!="" || txtOgrVizeNot.Text!="" || txtOgrFinalNot.Text!="")
            {
                DialogResult mesage = new DialogResult();
                mesage = MessageBox.Show("Günceilemek İstediğinize Eminmisiniz?", "Eminmisiniz!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (mesage == DialogResult.Yes)
                {
                    VeriTabani vt = new VeriTabani();
                    vt.baglantiyiAc();
                    try
                    {
                        SqlCommand guncellemeSorgu = new SqlCommand("UPDATE ogrenciler set ogrenci_ad = @ogrAd, ogrenci_soyad = @ogrSoyAd," +
                            " ogrenci_numara = @ogrNumura, ogrenci_vize = @ogrVize, ogrenci_final = @ogrFinal, ogrenci_ort = @ogrOrt  " +
                            " WHERE ogrenci_numara = @ogrNumura", vt.GetConnection());

                        float ogrVize = float.Parse(txtOgrVizeNot.Text), ogrFinal = float.Parse(txtOgrFinalNot.Text);
                        float ort = (float)Math.Round(((ogrVize * 0.4) + (ogrFinal * 0.6)), 4);

                        guncellemeSorgu.Parameters.Add("@ogrAd", SqlDbType.VarChar).Value = txtOgrAd.Text;
                        guncellemeSorgu.Parameters.Add("@ogrSoyAd", SqlDbType.VarChar).Value = txtOgrSoyAd.Text;
                        guncellemeSorgu.Parameters.Add("@ogrNumura", SqlDbType.Int).Value = int.Parse(txtogrNumara.Text);
                        guncellemeSorgu.Parameters.Add("@ogrVize", SqlDbType.Float).Value = ogrVize;
                        guncellemeSorgu.Parameters.Add("@ogrFinal", SqlDbType.Float).Value = ogrFinal;
                        guncellemeSorgu.Parameters.Add("@ogrOrt", SqlDbType.Float).Value = Math.Round(ort, 2);
                        guncellemeSorgu.ExecuteNonQuery();
                        MessageBox.Show("Kayıt Başarılı Bir Şekilde Güncellendi", "Tebrikler!");
                        ogrTemizle();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lütfen Tüm Bilgileri Kontrol Edin!!", "Uyarı!!");
                    }
                    vt.baglantiyiKapat();
                }
            }
            else
            {
                MessageBox.Show("Lütfen Seçim Yaptığınıza Yada Tüm Boşlukların Dolu Olduğuna Emin Olur!");
            }
        }

    }
}
