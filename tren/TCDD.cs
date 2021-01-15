using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tren
{
    public class TCDD
    {
        List<Musteri> musteriListesi   = new List<Musteri>();
        List<Bilet> biletListesi = new List<Bilet>();
        List<Sefer> seferListesi = new List<Sefer>();
        List<Rezervasyon> rezervasyonListesi = new List<Rezervasyon>();

       

        public List<Musteri> MusteriListesi
        {
            get { return musteriListesi; }
            
        }

        public List<Bilet> BiletListesi
        {
            get { return biletListesi; }

        }

        public List<Sefer> SeferListesi
        {
            get { return seferListesi; }

        }
        public List<Rezervasyon> RezervasyonListesi
        {
            get { return rezervasyonListesi; }

        }


        public void MusteriEkle(Musteri m)
        {
            musteriListesi.Add(m);
        }

        public void SeferEkle(Sefer s)
        {
            seferListesi.Add(s);
        }

        public void BiletEkle(Bilet b)
        {
            biletListesi.Add(b);
        }
        public void REzervasyonEkle(Rezervasyon b)
        {
            rezervasyonListesi.Add(b);
        }



    }
}
