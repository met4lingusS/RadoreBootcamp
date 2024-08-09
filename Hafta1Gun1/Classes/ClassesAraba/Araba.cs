using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadoreBootcamp_03082024.Classes.ClassesAraba
{
    public class Araba
    {
        public string marka;
        public string model;
        public string renk;
        public int kapıSayisi;
        public int pencereSayisi;

        public void gidiyor(string renk, string model, string marka)
        {
            Console.WriteLine($"{renk} {model} model {marka} Gidiyor");
        }
    }
}
