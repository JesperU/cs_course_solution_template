﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
    
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast navn");
            string navn = Console.ReadLine();
            string stortNavn = navn.ToUpper();

            Console.WriteLine("Velkommen "+stortNavn);
            Console.WriteLine("Tryk på en tast for at fortsætte");
            Console.ReadKey();
        }
    }
}
