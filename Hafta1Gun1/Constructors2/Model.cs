using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadoreBootcamp_03082024.Constructors.Constructors2
{
    public class Model
    {
        public string model;
        public Kasa kasa;
        public Fiyat fiyat;
        public Model(string model, Kasa kasa, Fiyat fiyat)
        {
            this.model = model;
            this.kasa = kasa;
            this.fiyat = fiyat;
        }
    }
}
