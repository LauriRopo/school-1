using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace läksyt.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* T2 KT4
             * Lue käyttäjältä kaksi kokonaislukua sekä operaatio.
             * Käytä operaation tallentamiseen string-tyyppistä muuttujaa.
             * Tutki switch-case rakenteessa minkä operaation käyttäjä syötti
             * ja tulosta sen perusteella lukujen laskutoimitus vastauksineen. 
             * Jos operaatio oli annettu väärin, niin tulosta virheilmoitus.
             * Nollalla jakoa ei saa ohjelmassa tapahtua!
             */

            int iluku1, iluku2, iVastaus;
            string sOperaatio;


            Console.Write("Anna kokonaisluku : ");
            iluku1 = int.Parse(Console.ReadLine());
            Console.Write("Anna toinen kokonaisluku : ");
            iluku2 = int.Parse(Console.ReadLine());

            

            Console.Write("Anna operaatio (+, -, / tai *) ");
            sOperaatio=Console.ReadLine();  

            switch(sOperaatio)
            {
                case "+":
                    Console.WriteLine("Summa {0} + {1} = {2}", iluku1, iluku2, iVastaus = iluku1 + iluku2);
                    break;

                case "-":

                    Console.WriteLine("Erotus {0} - {1} = {2}", iluku1, iluku2, iVastaus=iluku1 - iluku2);
                    break;

                case "/":
                    if (iluku1 != 0 || iluku2 != 0)
                    {
                        Console.WriteLine("Nollalla jako ei onnistu");
                        
                    }
                    else 
                    {
                        Console.WriteLine("Jakolasku {0} / {1} = {2}", iluku1, iluku2, iVastaus = iluku1 / iluku2);
                        break;

                    }

                    Console.WriteLine("Jakolasku {0} / {1} = {2}", iluku1, iluku2, iVastaus = iluku1 / iluku2);
                    break;

                case "*":

                    Console.WriteLine("Tulo {0} * {1} = {2}", iluku1, iluku2, iVastaus = iluku1 * iluku2);
                    break;

                default:
                    Console.WriteLine("Annoit operaation väärin!");
                    break;

                
                    
            }







        }
    }
}
