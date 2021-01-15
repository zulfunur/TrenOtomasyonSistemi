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

namespace tren
{
    public partial class Kullanici : Form
    {
        public Kullanici()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-GTKJS60\\SQLEXPRESS;Initial Catalog=db_trenOtomasyon;Integrated Security=True");
        public static string KullaniciAdi, KullaniciSifre;
        private void lblKullaniciAdi_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void btnYenii_Click(object sender, EventArgs e)
        {
            YeniKullaniciOlustur yn = new YeniKullaniciOlustur();
            yn.Show();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            baglan.Open();

            SqlCommand komut1 = new SqlCommand("select * from tbl_Giris k where k.KullaniciAdi=@k1 and k.KullaniciSifre=@k2", baglan);
            komut1.Parameters.AddWithValue("@k1", textBox1.Text);
            komut1.Parameters.AddWithValue("@k2", textBox2.Text);
            SqlDataReader dr = komut1.ExecuteReader();
            if (dr.Read())
            {
                KullaniciAdi = dr["KullaniciAdi"].ToString();
                KullaniciSifre = dr["KullaniciSifre"].ToString();
                Form1 frm = new Form1();
                frm.Show();
                Hide();
                
            }


            else
            {
                MessageBox.Show("Kullanıcı Adını ve Şifreyi Kontrol Ediniz.");
            }

            baglan.Close();
            
           
           
        }
    }
}
