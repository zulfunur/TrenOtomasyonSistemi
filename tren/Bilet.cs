using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tren
{
    public abstract class Bilet
    {
        public Rezervasyon rezervasyon { get; set; }
        public double Ucret { get; set; }

        public Bilet(Rezervasyon r)
        {
            rezervasyon = r;
            Ucret = r.sefer.Ucret;
            
        }
        
    }
}
