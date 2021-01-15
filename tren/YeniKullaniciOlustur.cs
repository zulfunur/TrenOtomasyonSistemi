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
using System.Text.RegularExpressions;


namespace tren
{
    public partial class YeniKullaniciOlustur : Form
    {
        public YeniKullaniciOlustur()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-GTKJS60\\SQLEXPRESS;Initial Catalog=db_trenOtomasyon;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            if (txtAdSoyadd.Text == "" || txtKullaniciAdii.Text == "" || TxtSifree.Text == "" || maskedTextBoxTC.Text == "" || maskedTextBoxTel.Text == "")
            {
                MessageBox.Show(" (*) Bu Alanları Boş Geçemezsiniz", "Boş Alan Hatası");

            }
            else
            {
                MessageBox.Show("Yeni Kayıt Oluşturulmuştur.");
            }


            int IDno = 0;
            baglan.Open();
            SqlCommand komut = new SqlCommand("insert into tbl_yeni (Y_ad_soyad,Y_tel,Y_tc) values(@ad,@tel,@tcno)", baglan);

            komut.Parameters.AddWithValue("@ad", txtAdSoyadd.Text);
            komut.Parameters.AddWithValue("@tel", maskedTextBoxTel.Text);
            komut.Parameters.AddWithValue("@tcno", maskedTextBoxTC.Text);
            komut.ExecuteNonQuery();
            baglan.Close();

            /* baglan.Open();
             SqlCommand komut3 = new SqlCommand("Select KullaniciId from tbl_Giris where KulaniciAdi='" + txtKullaniciAdii.Text + "'", baglan);
             komut3.CommandType = new CommandType();
             SqlDataReader dr5 = komut3.ExecuteReader();
             while (dr5.Read())
             {
                 IDno = Int32.Parse(dr5["KullaniciId"].ToString());
             }
             baglan.Close();*/

            baglan.Open();
            SqlCommand komut2 = new SqlCommand("insert into tbl_Giris (KullaniciAdi, KullaniciSifre) values(@tcno, @sifre)", baglan);
            komut2.Parameters.AddWithValue("@tcno", txtKullaniciAdii.Text);
            komut2.Parameters.AddWithValue("@sifre", TxtSifree.Text);
            komut2.ExecuteNonQuery();
            baglan.Close();

            this.Hide();



        }

        private void txtSifree_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtSifree_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider provider = new ErrorProvider();
            var t = (TextBox)sender;
            var m = Regex.Match(t.Text, @"((?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{6,})");
            if (!string.IsNullOrEmpty(t.Text) && !m.Success)
            {
                provider.SetError(t, "zayıf parola");
                e.Cancel = true;
            }
        }
    }
}
    
    
    
