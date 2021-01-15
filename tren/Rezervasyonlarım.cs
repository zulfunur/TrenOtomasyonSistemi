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
    public partial class RandevuGüncelleSil : Form
    {
        public RandevuGüncelleSil()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-GTKJS60\\SQLEXPRESS;Initial Catalog=db_trenOtomasyon;Integrated Security=True");


      

        private void RandevuGüncelleSil_Load(object sender, EventArgs e)
        {
            lblx.Text = Form1.vAd;
            lbly.Text = Form1.vTarih;
            label9.Text = Form1.vSoyad;
            label8.Text = Form1.vVaris;
            label7.Text = Form1.vKalkis;
        }

        private void btnRSil_Click(object sender, EventArgs e)
        {
            string deger = ""+label7.Text + " "+ ""+label8.Text + "  " + ""+lbly.Text + "\n Rezervasyonunuz Silinsin mi?";
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show(deger, "UYARI", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                if (lblx.Visible && lbly.Visible && label9.Visible && label8.Visible && label7.Visible)
                {
                    lblx.Visible = false;
                    lbly.Visible = false;
                    label9.Visible = false;
                    label8.Visible = false;
                    label7.Visible = false;
                }
                Form1 f = (Form1)Application.OpenForms["Form1"];
                f.temizle();

                this.Hide();
                MessageBox.Show("Rezervasyon Silme İşlminiz Başarıyla Gerçekleştirilmiştir.", "İyi Günler Dileriz...");

               
                
            }

            else
            {
                MessageBox.Show("İşleminiz iptal edilmiştir.");
            }

           
            
            /* lblx.Visible = false;
        else if (lbly.Visible)
             lbly.Visible = false;
         else if (label9.Visible)
             label9.Visible = false;
         else if (label8.Visible)
             label8.Visible = false;
         else if (label7.Visible)
             label7.Visible = false; */


        }
        
    }
}
