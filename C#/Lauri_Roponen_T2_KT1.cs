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
             Teema 2 KT1
            Lue käyttäjältä koenumero 4-10 väliltä. Jos käyttäjä syötti arvosanan
            väärin tulosta .
            Muussa tapauksessa tulosta:
            Hyvä 9 ta i10
            kelpo 7-8
            tyydyttävä 5-6
            heikko 4
            Toteuta if-rankenteella
            */

            int iluku;

            Console.Write("Kirjoita arvosana :");
            iluku = int.Parse(Console.ReadLine());

            if (iluku == 9 || iluku == 10)
            {
                Console.Write("Hyvä");
            }

            else if (iluku == 7 || iluku == 8)
            {
                Console.Write("Kelpo : ");
            }

            else if (iluku == 5 || iluku == 6)
            {
                Console.Write("tyydyttävä : ");
            }

            else if (iluku == 4)
            {
                Console.Write("heikko : ");
            }
            else
            {
                Console.Write("Et antanut arvosanaa annetulta väliltä : ");

            }

                
            

        }
    }
}
