using RadoreBootcamp_03082024.Classes.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadoreBootcamp_03082024.Classes.ClassesInsan
{
    public class Anne : Insan, IOku, IYaz

    // anne insan classından türemiştir
    // insandaki tüm public değişkenlere ve metotlara erişebilir
    {
        public void oku(string isim)
        {
            Console.WriteLine($"{isim} okuyor...");
        }

        public void yaz(string isim)
        {
            Console.WriteLine($"{isim} yazıyor...");
        }
    }
}
