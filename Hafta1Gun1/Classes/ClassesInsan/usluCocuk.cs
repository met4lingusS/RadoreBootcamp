using RadoreBootcamp_03082024.Classes.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadoreBootcamp_03082024.Classes.ClassesInsan
{
    public class usluCocuk : Cocuk, IDinle, IYaz
    {
        public void dinle(string isim)
        {
            Console.WriteLine($"{isim} dinliyor...");
        }

        public void yaz(string isim)
        {
            Console.WriteLine($"{isim} yazıyor...");
        }
    }
}
