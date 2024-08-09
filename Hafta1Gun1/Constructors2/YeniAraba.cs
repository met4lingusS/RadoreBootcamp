using RadoreBootcamp.Constructors2;
using RadoreBootcamp_03082024.Constructors.Constructors2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadoreBootcamp_03082024.Constructors.Constructors2
{
    public class YeniAraba
    {
        public Marka marka;
        public YeniAraba(Marka marka)
        {
            this.marka = marka;
        }

        public void arabaSiparisi()
        {
            Console.WriteLine($@"Sipariş edilen arabanın;
                        Markası: {marka.marka}
                        Modeli: {marka.model.model}
                        Kapı Sayısı: {marka.model.kasa.kapi.kapiSayisi}
                        Pencere Sayısı: {marka.model.kasa.pencere.pencereSayisi}
                        Kasa Tipi: {marka.model.kasa.tip}
                        Fiyatı: {marka.model.fiyat.fiyat} TL'dir.");
        }
        
    }
}


