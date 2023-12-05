using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        /* Teema 4 KT 2
         * Esittele 10 alkioinen int taulukko ja arvo siihen lukuja väliltä 0-10.
         * Vain parilliset luvut sallitaan. Jos arvottiin pariton luku niin sen tilalle on arvottava uusi luku.
         * Tulosta luvut lopuksi tabulaattorilla eroteltuna
         * 
         * */

        static void Main()
        {

            int[] taulu = new int[10];
            int i;
            Random rnd = new Random();
            


            for (i = 0; i < taulu.Length; i++)
            {
                taulu[i] = rnd.Next(0, 11);


                 if (taulu[i] % 2 == 0)
                 {
                    Console.Write("{0} \t", taulu[i]);
              
                 }
                 if (taulu[i] % 2 == 1)
                 {
                    i--;
                 }
                 
                
                  
                 
                
            }Console.WriteLine();
          
            
             
                

            


            





























        }

    }       
}
