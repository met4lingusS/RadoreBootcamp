using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadoreBootcamp3.Reflections
{
    public class MyClass
    {
        public int x;
        public int y;

        public void MesajGöster()
        {
            Console.WriteLine($"x'in değeri: {x}, y'nin değeri: {y}");
        }

        public string MesajDon()
        {
            return " bir mesaj";
        }

        public MyClass(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public bool IsPositive(int i)
        {
            if (i >= 0) return true;
            return false;
            
        }
    }
}
