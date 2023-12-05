using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohjelmoiti2Läksy
{
    internal class Program
    {
        /*
         * Esittele tietue (struct), jolla on kaksi kokonaislukuarvoa.
         * Toinen niistä on kuljettu matka (km) ja toinen on kulutettu polttoainemäärä (l).
         * Esittele tietueesta muuttuja ja kysy käyttäjältä arvot tietueen muuttujiin.
         * Tulosta polttoaineen kulutus (litraa/100km) siten, että käytät tietueeseen tallennettuja arvoja. 
         * Tässä ei tarvitse käyttää tietueen sisäisiä funktioita.
         * 
         */

        struct Arvot
        {
            public int iMatka;
            public int iPaine;
        }

        static void Main(string[] args)
        {
            Arvot a;

            Console.WriteLine("Kerro kuljettu matka (km)");
            int.TryParse(Console.ReadLine(), out a.iMatka);
            Console.Clear();

            Console.WriteLine("Kerro kulutetun polttoaineen määrä");
            int.TryParse(Console.ReadLine(), out a.iPaine);
            Console.Clear();

            Console.WriteLine("Poltto aineen kulutus (litraa/100Km) : {0:f2} ", a.iMatka / a.iPaine);

        }
    }
}
