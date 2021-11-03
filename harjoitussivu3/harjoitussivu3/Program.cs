using System;

namespace harjoitussivu3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            if(x >= y) {
                Console.WriteLine(x + ", "+ y);
            }else
            {
                Console.WriteLine(y + ", " + x);
            }

            Console.WriteLine();
           int z = int.Parse (Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            if (z > a && z > p)
            {
                Console.WriteLine(z);
            }
            else if (a >p&&a > z)
            {
                Console.WriteLine(a);
            }
            else if (p > a && p > z)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();
            string kk = Console.ReadLine();
            switch (kk)
            {
                case "0":
                    Console.WriteLine("nolla");
                    break;
                case "1":
                    Console.WriteLine("yksi");
                    break;
                case "2":
                    Console.WriteLine("kaksi");
                    break;
                case "3":
                    Console.WriteLine("kolme");
                    break;
                case "4":
                    Console.WriteLine("neljä");
                    break;
                case "5":
                    Console.WriteLine("viisi");
                    break;
                case "6":
                    Console.WriteLine("kuusi");
                    break;
                case "7":
                    Console.WriteLine("seitsemän");
                    break;
                case "8":
                    Console.WriteLine("kahdeksan");
                    break;
                case "9":
                    Console.WriteLine("yhdeksän");
                    break;
                default:
                    Console.WriteLine("luvin täytyy olla 0-9");
                    break;


            }
        }
    }
}
                