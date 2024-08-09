using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadoreBootcamp_03082024.Classes.ClassesInsan
{
    public class Cocuk : Insan
    {
        public string adjective;

        public void inf(string name, string lastname, string adjective)
        {
            Console.WriteLine($"{name} {lastname} {adjective}");
        }
    }
}
