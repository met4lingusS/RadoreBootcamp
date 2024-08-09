using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadoreBootcamp.Odevler.Odev2.AbstractClasses
{
    public abstract class Araba
    {
        public string marka;
        public string model;
        public string renk;
        public int kapıSayisi;
        public int pencereSayisi;

        public abstract double depo();
        
    }
}
