using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        /* T3 KT3
         * Laita vakioon ARVATTAVA_LUKU joku arvo väliltä 1-500.Tee ohjelma, joka pyytää arvaamaan lukua.
         * Jos käyttäjä syötti isomman luvun kuin vakiossa, niin tulosta : ”Annoit liian ison luvun”.
         * Jos taas käyttäjän syöttämä luku oli pienempi kuin vakion luku niin tulosta : ”Annoit liian pienen luvun”.
         * Kun käyttäjä arvaa luvun oikein niin tulosta : ”Oikein, arvasit luvun 27 kerralla!”
         * Missä siis arvo 27 kertoo montako kierrosta meni ennen kuin käyttäjä arvasi oikein
         */

        static void Main(string[] args)
        {

            int luku=0, i = 0;

            while (luku != 42)
            {
                if (luku != 42)
                {

                    Console.WriteLine("Yritä arvata oikea luku 1-500. Yrityksiä {0}", i);
                    luku = int.Parse(Console.ReadLine());
                    i++;
                }
                if(luku >= 43)
                {
                    Console.WriteLine("Annoit liian suuren luvun");
                }
                if (luku <= 41)
                {
                    Console.WriteLine("Annoit liian pienen luvun");

                }
                if(luku == 42)
                {
                    Console.WriteLine("Arvasit oikein!! Yritys kertoja {0}", i);
                }

            }
            
            
            



        }
    }
}
