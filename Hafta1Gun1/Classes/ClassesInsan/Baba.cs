using RadoreBootcamp_03082024.Classes.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadoreBootcamp_03082024.Classes.ClassesInsan
{
    public class Baba : Insan, IOku, IDinle
    {
        public void dinle(string isim)
        {
            Console.WriteLine($"{isim} dinliyor...");
        }

        public void oku(string isim)
        {
            Console.WriteLine($"{isim} okuyor...");
        }
    }
}
