// See https://aka.ms/new-console-template for more information
using RadoreBootcamp_03082024.Classes.ClassesAraba;
using RadoreBootcamp_03082024.Classes.ClassesInsan;
using RadoreBootcamp_03082024.Constructors;

//Console.WriteLine("Hello, World!");


// classname objectname = new classname();


// Araba
/*
Araba mustang = new Araba();
mustang.marka = "Mustang";
mustang.model = "1967";
mustang.renk = " Koyu Yeşil";
mustang.kapıSayisi = 2;
mustang.pencereSayisi = 2;
mustang.gidiyor(mustang.renk, mustang.model, mustang.marka);
*/
/*
Insan i = new Insan();
i.name = "Semih";
i.lastname = "VATANSEVER";
i.age = 28;
i.salary = 3.14;
i.gender = true;
i.sleep(i.name, i.lastname);
i.family_tree = "Çocuk";
i.information(i.name, i.lastname, i.family_tree);

Insan semih = new Insan("Semih", "VATANSEVER");
semih.family_tree = "Çocuk";
semih.information(semih.name, semih.lastname, semih.family_tree);
*/

/*
Anne an = new Anne();
an.name = "Hafize";
an.lastname = "VATANSEVER";
an.age = 65;
an.family_tree = "Anne";
an.information(an.name, an.lastname, an.family_tree);
an.oku(an.name);
an.yaz(an.name);

Baba ba = new Baba();
ba.name = "Hidayet";
ba.lastname = "VATANSEVER";
ba.age = 62;
ba.family_tree = "Baba";
ba.information(ba.name, ba.lastname, ba.family_tree);
ba.oku(ba.name);
ba.dinle(ba.name);


akilliCocuk cocuk = new akilliCocuk();    
cocuk.name = "Semih";
cocuk.lastname = "VATANSEVER";
cocuk.adjective = "akıllıdır.";
cocuk.inf(cocuk.name, cocuk.lastname, cocuk.adjective);
cocuk.dinle(cocuk.name);
cocuk.yaz(cocuk.name);
cocuk.oku(cocuk.name);


usluCocuk uslu = new usluCocuk();
uslu.name = "Mehmet";
uslu.lastname = "Yıldız";
uslu.adjective = "usludur.";
uslu.inf(uslu.name, uslu.lastname, uslu.adjective);
uslu.dinle(uslu.name);
uslu.yaz(uslu.name);
*/

/*
Matematik m = new Matematik();

int gelenDeger = m.topla(5, 5);
Console.WriteLine($"Toplam: {gelenDeger}");

m.topla(5, 5, 10);

 */
/*
Goz goz = new Goz("Kahverengi", "retina", 30, 30);
Kulak kulak = new Kulak("normal");
Burun burun = new Burun("Kemerli");
Kafa kafa = new Kafa(goz, burun, kulak);
YeniInsan semih = new YeniInsan("Semih", "VATANSEVER", kafa);
semih.randevuKayit();
*/


//diziler
/*
string[] gunler = new string[7];

gunler[0] = "pazartesi";
gunler[1] = "salı";
gunler[2] = "çarşamba";
gunler[3] = "perşembe";
gunler[4] = "cuma";
gunler[5] = "cumartesi";
gunler[6] = "pazar";

for (int i = 0; i < gunler.Length; i++)
{
    Console.WriteLine(gunler[i]);
}

int[] sayilar = { 2, 4, 6, 7, 9, 11, 22, 33, 44, 55, 66 };
int toplam = 0;
for (int i = 0;i < sayilar.Length; i++)
{
    toplam += sayilar[i];
}
Console.WriteLine(toplam);
*/
// generic class lar boxing ve unboxing işlemlerde performans kaybını da engeller

/*
List<int> liste = new List<int>();
liste.Add(35);
Console.WriteLine(liste[0]);
//liste.Add(true); // true int olmadığı için hata verir
//liste.Add(3.14); // 3.14 int olmadığı için hata verir 
liste.Insert(0, 55);
Console.WriteLine(liste[0]);
*/
