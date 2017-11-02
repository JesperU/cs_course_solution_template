using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variabler
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 12.5;
            x*=2;
            
            Console.WriteLine(x);
            

            FilTyper ft = FilTyper.csv;
            Console.WriteLine(ft);


            DateTime dato = DateTime.Now;
            Console.WriteLine(dato.ToString("dMy"));


            

            Person p;
            p.id = 1;
            p.Navn = "Mikkel";

            Console.WriteLine(p.Navn);
            Console.ReadKey();

        }
    }

enum FilTyper
    {
        csv,
        pdf,
        txt
    }

    struct Person
    {
        public int id;
        public string Navn;
    }

}
