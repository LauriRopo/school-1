using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp3
{
    internal class Program
    {
        /* T5 KT1
         * Tee ohjelma, jossa kysytään KysyJaTestaaLuku() nimisessä funktiossa  käyttäjältä kokonaisluku. 
         * Funktio palauttaa kokonaislukuarvon seuraavasti:
         * 
                 1, jos syötetty luku on positiivinen.
                 0, jos syötetty luku on nolla.

                 -1, jos syötetty luku on negatiivinen. 

        Tulosta näiden paluuarvojen perusteella Mainissa ilmoitus ruudulle.

                ”Luku oli positiivinen”, jos paluuarvo oli 1.
                ”Luku oli nolla”, jos paluuarvo oli 0
                ”Luku oli negatiivinen”, jos paluuarvo oli -1.


        Käyttäkää Mainissa switch-case-rakennetta
          */

        static int KysyJaTestaa()
        {
            int luku;
            Console.WriteLine("Kirjoita kokonaisluku : ");
            luku = int.Parse(Console.ReadLine());

            if (luku == 0)
            {
                return 0;
            }
            else if (luku < 0) 
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }


        static void Main()
        {
            int iPaluu;

            iPaluu = KysyJaTestaa();

            switch (iPaluu)
            {
                case 0:
                    Console.WriteLine("Luku oli nolla");
                    break;
                case 1:
                    Console.WriteLine("Luku oli positiivinen");
                    break;
                case -1:
                    Console.WriteLine("Luku oli negatiivinen");
                    break;
            }
            Console.WriteLine();








        }
            
    }       
}
