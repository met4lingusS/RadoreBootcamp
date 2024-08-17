using RadoreBootcamp3.Reflections;
using System.Reflection;

Type t = typeof(MyClass);

MethodInfo[] mi = t.GetMethods();

Console.WriteLine($"Nesnenin adı: {t.Name}");
foreach (MethodInfo info in mi)
{
    ParameterInfo[] p = info.GetParameters();
    Console.WriteLine("------------");
    Console.WriteLine($"Metod Adı: {info.Name}\nDönüş Tipi: {info.ReturnType}");
    if ( p.Length > 0)
    {
        Console.WriteLine($"{p.Length} adet parametre var.");
    }
    for (int iX = 0; iX < p.Length; iX++)
    {
        Console.WriteLine($"{(iX + 1)}. parametre:\n- Adı: {p[iX].Name}\n- Dönüş Değeri: {p[iX].ParameterType.Name}");
    }
    
    Console.WriteLine("------------");


}