using RadoreBootcamp.Constructors2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadoreBootcamp_03082024.Constructors.Constructors2
{
    public class Kasa
    {
        public string tip;
        public Kapi kapi;
        public Pencere pencere;


        public Kasa(string tip, Kapi kapi, Pencere pencere)
        {
            this.tip = tip;
            this.kapi = kapi;
            this.pencere = pencere;
        }
    }
}
