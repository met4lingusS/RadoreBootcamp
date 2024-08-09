using RadoreBootcamp.Odevler.Odev2.Interfaces;
using RadoreBootcamp.Odevler.Odev2.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RadoreBootcamp.Odevler.Odev2.Classes
{
    public class mustang : Araba, IFavori
    {
        public override double depo()
        {
            return 63.22;
        }

        public void favori(string marka)
        {
            Console.WriteLine($"{marka} favorim!!!");
        }
    }
}
