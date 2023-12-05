using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        /* Teema 4 KT1
         * Esittele 3 alkioinen double taulukko ja lue siihen käyttäjältä arvot.
         * Tulosta lopuksi syötettyjen lukujen summa ja keskiarvo
         * */

        static void Main()
        {

            double[] taulu = new double[3];
            int i;
            double keskiaro;

            for (i = 0; i < 3; i++)
            {

                Console.Write("Kerro arvo {0} : ", i + 1);
                taulu[i] = double.Parse(Console.ReadLine());
            }


            Console.WriteLine("Summa : {0} ", taulu[0] + taulu[1] + taulu[2]);
            keskiaro = (taulu[0] + taulu[1] + taulu[2]) / 3;
            Console.WriteLine("Keskiarvo : {0:F2}", keskiaro);





























        }

    }       
}
