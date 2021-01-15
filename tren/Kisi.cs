using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tren
{
   public class Kisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TcNo { get; set; }
        private Iletisim iletisim= new Iletisim ();

        public Iletisim Iletisim
        {
            get { return iletisim; }
            set { iletisim = value; }
        }
        
       
    }
}
