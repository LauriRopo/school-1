using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        /* T3 KT2
         * Esittele kaksi laskurimuuttujaa ja tulosta niiden avulla for-silmukassa:
         *  11       10
            12        9
            13        8
            19        2
            20        1
        Eli toinen arvo toisesta muuttujasta ja toinen toisesta*/

        static void Main(string[] args)
        {
            int i, j;
            

            for(i = 10, j=11; i >= 1 && j <=20; i--, j++)
            {
                Console.WriteLine("{0}\t{1}", i, j);
                

            }
            



        }
    }
}
