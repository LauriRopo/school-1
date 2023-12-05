using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        /* T3 KT4
         * Kysy käyttäjältä mistä luvusta aloitetaan tulostus ja mihin lopetanaan ja myös askellus.
         * Mistä on oltava pienempi kuin mihin ja askelluksen oltava suurempi kuin 0.
         * Muuten kysyttävä tiedot uudestaan.
         * 
         *
         */

        static void Main(string[] args)
        {

            int aloitus, lopetus, askellus;

            Console.Write("Kerro luku mistä haluat aloitta: ");
            aloitus = int.Parse(Console.ReadLine());
            Console.Write("Kerro viimeinen luku: ");
            lopetus = int.Parse(Console.ReadLine());
            Console.Write("Kerro myös millä askelluksella: ");
            askellus = int.Parse(Console.ReadLine());

            while (askellus !=0 && aloitus <= lopetus)
            {
                Console.WriteLine(aloitus);
                aloitus += askellus;

            }
            Console.WriteLine();






        }

    }       
}
