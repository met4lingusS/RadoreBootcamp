using RadoreBootcamp_03082024.Odevler.Odev1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadoreBootcamp_03082024.Odevler.Odev1
{
    public class ProgramRadoreOdev1
    {
        
        static void Main (string[] args)
        {
            
            GenelMudur gm = new GenelMudur ();
            gm.unvan = "Genel Müdür";
            gm.maas = gm.maasinizNedir();
            gm.adiSoyadi = "Semih";
            Mudur m = new Mudur ();
            m.unvan = "Müdür";
            m.maas = m.maasinizNedir();
            m.adiSoyadi = "Hakan YILMAZ";
            Developer dev = new Developer ();
            dev.unvan = "Programcı";
            dev.maas = dev.maasinizNedir();
            dev.adiSoyadi = "Mehmet YILDIZ";
            Stajyer stj = new Stajyer();
            stj.unvan = "Stajyer";
            stj.maas = stj.maasinizNedir();
            stj.adiSoyadi = "Semih VATANSEVER";
            
            double toplamMaas = 0.0;
            toplamMaas += gm.maas;
            toplamMaas += m.maas;
            toplamMaas += dev.maas;
            toplamMaas += stj.maas;

            Console.WriteLine($"Toplam çalışan maliyeti: {toplamMaas}");
            Console.WriteLine();
            Personel[] calisanlar = {gm, m, dev, stj};
            double maasToplam = 0.0;
            for (int i = 0; i < calisanlar.Length; i++)
            {
                maasToplam += calisanlar[i].maas;
                Console.WriteLine($"{calisanlar[i].unvan} pozisyonunun maaşı: {calisanlar[i].maas} TL'dir.");
            }
            Console.WriteLine($"Toplam çalışan maliyeti ise {maasToplam} TL'dir");
            Console.WriteLine();
            
            List<Personel> personels = new List<Personel> ();
            personels.Add (gm);
            personels.Add (m);
            personels.Add (dev);
            personels.Add (stj);

            double calisanMaliyeti = 0.0;
            // foreach, objeler üzerinde for'a göre daha verimli çalışır
            foreach (Personel personel in personels)
            {
                Console.WriteLine($"{personel.unvan} pozisyonundaki {personel.adiSoyadi} ad soyadlı personelin maaşı: {personel.maas} TL'dir.");
                calisanMaliyeti += personel.maas;
            }
            Console.WriteLine($"Şirketin toplam çalışan maliyeti: {calisanMaliyeti} TL'dir");
        }
          
    }
}
