using RadoreBootcamp.Odevler.Odev2.Interfaces;
using RadoreBootcamp.Odevler.Odev2.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadoreBootcamp.Odevler.Odev2.Classes
{
    public class mercedes : Araba, IYuzuyor, IUcuyor
    {
        public override double depo()
        {
            return 70.0;
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
