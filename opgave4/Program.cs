﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person k1 = new Person();
            k1.navn = "a";

            Person k2 = new Person();
            k2.navn = "b";

            Console.WriteLine(k1.navn + " og "+k2.navn);

            Console.ReadKey();



        }
    }
    struct Person
    {
        public string navn;
    }
}
