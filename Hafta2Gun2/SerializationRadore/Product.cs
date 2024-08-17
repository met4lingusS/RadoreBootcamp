using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SerializationRadore
{
    [Serializable]
    public class Product
    {
        public string name { get; set; }

        public DateTime expireDate { get; set; }

        public double price { get; set; }
    }
}
