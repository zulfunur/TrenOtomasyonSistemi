using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tren
{
    public class YasliBilet:Bilet
    {
        public YasliBilet(Rezervasyon r): base(r)
        {
            Ucret *= 0.5;
        }
    }
}
