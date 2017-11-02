using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] månedsløn = { 10000, 2000, 15000, 20000, 30000, 15000 };
            double gs;
            gs = 0;
            for (int i = 0; i < månedsløn.Length; i++)
            {
                gs = gs + månedsløn[i];
                Console.WriteLine(månedsløn[i]);
            }
            gs = gs / månedsløn.Length;


            Console.WriteLine("Gennemsnit=" + gs);

            Console.ReadKey();
        }
    }
}
