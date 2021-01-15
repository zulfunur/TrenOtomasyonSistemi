using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tren
{
    public class Rezervasyon
    {
        public Sefer sefer { get; set; }
        public Musteri müsteri { get; set; }
        

        public Rezervasyon(Musteri m, Sefer s)
        {
            sefer = s;
            müsteri = m;
            müsteri.Puan += sefer.Ucret  * 0.001;
        }

        

    }
}
