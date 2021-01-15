using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tren
{
    public class Sefer
    {
        public string SeferTipi { get; set; }
        public DateTime GidisTarihi{ get; set; }
        public DateTime DonusTarihi { get; set; }
        public string KalkısYeri { get; set; }
        public string VarısYeri { get; set; }
        public double Ucret { get; set; }

        public double SeferUcretiHesapla(double kalkis,double varis)
        {
            double KMfiyati = 0.1;
            return Math.Abs((kalkis + varis) * KMfiyati);
        }

    }
}
