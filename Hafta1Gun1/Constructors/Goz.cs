using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadoreBootcamp_03082024.Constructors
{
    public class Goz
    {
        public string renk;
        public string retina;
        public int genislik;
        public int yükseklik;
        public Goz(string renk, string retina, int genislik, int yükseklik)
        {
            this.renk = renk;
            this.retina = retina;
            this.genislik = genislik;
            this.yükseklik = yükseklik;
        }    
    }
}
