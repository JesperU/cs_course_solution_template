using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave5
{
    class Program
    {
        static void Main(string[] args)
        {
            string fornavn = "Kalle";
            string efternavn = " Udesen";

            string Samlet;
            string SAMLET;
            string samlet;
            string[] del;

            Samlet = fornavn + efternavn;
            SAMLET = Samlet.ToUpper();
            samlet = Samlet.ToLower();
            del = Samlet.Split(' ');


            Console.WriteLine(Samlet);
            Console.WriteLine(SAMLET);
            Console.WriteLine(samlet);
            Console.WriteLine(del[0]+" "+del[1]);

            for (int i = 0; i < del.Length; i++)
            {
                Console.Write(del[i]);
                Console.Write(" ");
            }


            System.IO.File.WriteAllText(@"c:\temp\test.txt",Samlet);

            Console.ReadKey();

        }
    }
}
