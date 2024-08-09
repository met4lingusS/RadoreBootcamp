using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadoreBootcamp_03082024.Classes
{
    public class Matematik
    {
        // topla metodu iki int tipinde değer alacak ve geriye int döndürecek
        public int topla(int sayi1, int sayi2,int sayi3)
        {
            int sonuc = 0;
            sonuc = sayi1 + sayi2 + sayi3;
            return sonuc;
        }
        public int topla(int sayi1, int sayi2)
        {
            int sonuc = 0;
            sonuc = sayi1 + sayi2;
            return sonuc;
        }

        public int cıkar(int sayi1, int sayi2)
        {
            int sonuc = 0;
            sonuc = sayi1 - sayi2;
            return sonuc;
        }

    }
}
