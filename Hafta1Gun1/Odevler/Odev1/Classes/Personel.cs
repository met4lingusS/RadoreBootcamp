using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadoreBootcamp_03082024.Odevler.Odev1.Classes
{
    public abstract class Personel
    {

        public string unvan;
        public double maas;
        public string adiSoyadi;

        // bu classtan türeyen tüm classlar böyle bir metodun içini doldurmak zorundalar, implemente etmek zorunda, interface de olduğu gibi
        public abstract double maasinizNedir();
                
        public void mesaiyeBasla()
        {
            Console.WriteLine("Mesai başladı");
        }    


    }
}
