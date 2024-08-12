using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadoreBootcamp2.Overrides
{
    public class Child : Parent
    {
        // Buradaki yaz metodu var olduğu sürece Parenttaki metodu override edecektir
        public void yaz()
        {
            Console.WriteLine("Child sınıfındaki yaz metodu çağrıldı.");
        }
        

    }
}
