﻿using System;

using System;
using System.Collections.Generic;
using System.Linq;

namespace harjoitussivu4
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            switch (input)
            {
                case int:
                    input++;
                    break;
                case float:
                    input++;
                    break;
                case string:
                    input = input + "*";

                default:
                    Console.WriteLine(" You did not type a or b");
                    Console.WriteLine();
                    Console.ReadLine();
                    break;
            }
        }
    }
}
