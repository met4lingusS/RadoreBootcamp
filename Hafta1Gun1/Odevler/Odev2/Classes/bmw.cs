using RadoreBootcamp.Odevler.Odev2.Interfaces;
using RadoreBootcamp.Odevler.Odev2.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadoreBootcamp.Odevler.Odev2.Classes
{
    public class bmw : Araba, IUcuyor, IYuzuyor, IGidiyor
    {
        public override double depo()
        {
            return 60.0;
        }

        public void hizli(string marka)
        {
            Console.WriteLine($"{marka} çok hızlı gidiyor");
        }

        public void ucuyor(string marka)
        {
            Console.WriteLine($"{marka} havada uçuyor");
        }

        public void yuzuyor(string marka)
        {
            Console.WriteLine($"{marka} denizde yüzüyor");
        }
    }
}
