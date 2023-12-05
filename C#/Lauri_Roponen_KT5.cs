using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            KT5
            Esittele muuttuja pii, jolle annat alkuarvoksi piin likiarvon 6 desimaalin tarkkuudella.
            Lue käyttäjältä ympyrän halkaisija ja tulosta ympyrän piiri ja pinta-ala.

           */

            double dPii;
            int iHalkaisija;
            int iPiiri;
            int iPinta;
            int iSäde;

            dPii = 3.141592;

            Console.WriteLine("Ympyrän halkaisija");
            iHalkaisija = int.Parse(Console.ReadLine());

            iPiiri= ((int)(dPii * iHalkaisija));
            iSäde = iHalkaisija / 2;
            iPinta = ((int)(dPii * (iSäde * iSäde)));


            Console.WriteLine("Ympyrän piiri on {0:}", iPiiri);
            Console.WriteLine("ja pinta-ala on {0:}", iPinta);









        }
    }
}
