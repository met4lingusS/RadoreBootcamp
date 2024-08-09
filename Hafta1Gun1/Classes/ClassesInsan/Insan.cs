using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadoreBootcamp_03082024.Classes.ClassesInsan
{
    public class Insan
    { // starting scope
        // public: access modifier
        // access modifier datatype variablename
        public string name = "Semih123"; //alfanumeric değerler
        public string lastname = null;
        public int age; // stores whole numbers, default is 0
        public double salary; // store decimal numbers, default is 0.0
        public bool gender; // true or false, default is false 
        public string family_tree;
        // there are 2 types of methods
        // 1. returning values
        // 2. non returning values

        // access modifiers type_of_return methodname() {}
        public void sleep(string name, string lastname)
        {
            Console.WriteLine($"{name} {lastname} is sleeping...");
        }

        public void information(string name, string lastname, string family_tree)
        {
            Console.WriteLine($"Kişinin adı {name}, kişinin soyadı {lastname} - {family_tree}");
        }


        // boş constructor
        // class ismi ile aynı ve geri dönüş tipi olmayan metotlar
        public Insan()
        {

        }

        // parametre alan constructor
        // bir classtan nesne oluştururken aynı anda tanımlamayı da sağlar
        public Insan(string isim, string soyisim)
        {
            name = isim;
            lastname = soyisim;
        }

        public Insan(string isim, string soyisim, string family_tree, int yas, double maas, bool cinsiyet)
        {
            name = isim;
            lastname = soyisim;
            this.family_tree = family_tree;
            gender = cinsiyet;
            age = yas;
            salary = maas;
        }

    } // ending scope

}
