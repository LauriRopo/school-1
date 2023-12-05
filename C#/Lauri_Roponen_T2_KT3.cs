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
            /* Teema 2 KT3
             * Tee ohjelma joka pyytä käyttäjältä lämpötilan arvon.
             * Ohjelma sitten tulostaa seuraavasti
             * >39 Liian kuuma
             * 11..39 Lämmintä
             * 0..10 Haalea
             * -30..-1 Pakkasta
             * <- 30 Liian kylmä
             */

            int dlampo;

            Console.Write("Ilmoita lämpötila :");
            dlampo = int.Parse(Console.ReadLine());

            if (dlampo <= -39)
            {
                Console.WriteLine("Liian kylmä");
            }
            else if (dlampo >= -30 && dlampo <= -1)
            {

                Console.WriteLine("Pakkasta");


            }
            else if (dlampo >= 0 && dlampo <= 10)
            {
                Console.WriteLine("Haalea");
            }
            else if (dlampo >= 11 && dlampo <= 39)
            {
                Console.WriteLine("Lämmintä");
            }
            else if (dlampo >= 40)
                {

                Console.WriteLine("Liian kuuma");
            }









        }
    }
}
