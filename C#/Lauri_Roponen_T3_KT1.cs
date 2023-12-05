using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace läksyt.cs
{
    internal class Program
    {
        static void Main()
        {
            /* T3 KT1
             * Lue käyttäjältä lukuja while silmukassa, kunnes syötetään arvo -1.
             * Sen jälkeen tulosta lukujen keskiarvo, lukua -1 ei oteta laskuun mukaan.
             */

            int i = 0, luku, summa = 0;
            


            while (i != -1)
            {
                Console.WriteLine("Syötä luku, -1 lopettaa");
                luku = int.Parse(Console.ReadLine());
                


                if(luku !=-1) 
                {
                    summa += luku;
                    i++;

                }
                else if( luku ==-1)
                {
                    luku--;
                    Console.WriteLine("Lukujen keskiarvo on {0}", summa / i);
                    break;
                }

            }































        }




    }
        
}
