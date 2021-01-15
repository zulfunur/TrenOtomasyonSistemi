using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tren
{
    public partial class frmKrediKarti : Form
    {
        public frmKrediKarti()
        {
            InitializeComponent();
        }

        private void btnBilgileriAl_Click(object sender, EventArgs e)
        {
            try
            {
                KrediKarti kredikarti = new KrediKarti();
                kredikarti.AdSoyad = txtKartAdSoyad.Text;
                kredikarti.KartNo = int.Parse(txtKartno.Text);
                kredikarti.SKT = int.Parse(txtSKT.Text);
                kredikarti.CVC = int.Parse(txtCVC.Text);
                MessageBox.Show("Bilgileriniz doğrulandı.Biletiniz alınmıştır.İyi yolculuklar dileriz...");
                this.Hide();
            }
            catch (Exception )
            {
                MessageBox.Show("Lütfen Tüm Alanları istenen Şekilde Doldurunuz!","HATA!",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                
            }
            


            
        }

        private void txtKartno_Click(object sender, EventArgs e)
        {
            txtKartno.Text = "";
        }

        private void txtKartAdSoyad_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSKT_Click(object sender, EventArgs e)
        {
            txtSKT.Text = "";
        }

        private void txtCVC_Click(object sender, EventArgs e)
        {
            txtCVC.Text = "";
        }

        private void txtKartAdSoyad_Click(object sender, EventArgs e)
        {
            txtKartAdSoyad.Text = "";
        }

        private void frmKrediKarti_Load(object sender, EventArgs e)
        {

        }
    }
}
