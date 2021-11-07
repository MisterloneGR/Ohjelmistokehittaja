using System;
using System.Collections.Generic;
using System.Linq;

namespace harjoitussivu4
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            List<int> lista = new List<int>();
            lista.Add(x);
            lista.Add(y);

            lista.Add(z);
            lista.Add(b);
            lista.Add(a);
            var maxArvo = lista.Max();
            System.Console.WriteLine(maxArvo);  
        }
    }
}
