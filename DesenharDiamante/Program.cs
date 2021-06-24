using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesenharDiamante
{
    class Program
    {
        static void Main(string[] args)
        {
            Diamante d = new Diamante("Z");
            for (int i = 0; i < d.diamantePronto.Length; i++)
            {
                Console.WriteLine(d.diamantePronto[i]);
            }
            Console.ReadLine();
        }
    }
}
