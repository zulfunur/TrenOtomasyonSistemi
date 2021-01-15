using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tren
{
    public class KrediKarti:Odeme
    {
        public int KartNo { get; set; }
        public string AdSoyad { get; set; }
        public int CVC { get; set; }
        public int SKT { get; set; }
    }
}
