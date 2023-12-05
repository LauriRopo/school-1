
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp3
{
    internal class Program
    {
        /* T5 KT5
        Luo 7 alkioinen float-taulukko ja lue siihen käyttäjältä arvoja.
        Kun käyttäjä syöttää arvoa taulukkoon, niin ohjelma ei saa kaatua vaan väärä arvo on kysyttävä uudestaan. 
        Lajittele taulukko ja tulosta taulukon minimi- ja maksimiarvot.
        Käytä funktioita:

        LuoTaulukko
        KysyArvotTaulukkoon
        LajitteleTaulukko
        TulostaTiedot*/

        static int LuoTaulukko()
        {
            Console.Write("Kuinka iso taulukko luodaan : ");
            return int.Parse(Console.ReadLine());
        }
        static void KysyArvotTaulukkoon(float[]taulu)
        {
            float i;
            for(i = 0; i < taulu.Length; i++)
            {   
                if (i.GetType() == typeof(float))
                {
                    Console.WriteLine("Kerro {0}. arvo : ", i + 1);
                    taulu[(int)i] = float.Parse(Console.ReadLine());
                }
                else
                {

                    Console.WriteLine("Syötit arvon väärin, syötä uudestaan");
                    i--;
                }
                

            }
 
        }
        static void LajitteluTulosta(float[]taulu)
        {
            Array.Sort(taulu);
   
        }
        static void TulostaTiedot(float[]taulu)
        {
            Console.Clear();
            Console.WriteLine("Maksimiarvo {0} ja minimiarvo {1}", taulu.Max(), taulu.Min());   
        }
        

        static void Main()
        {
            float[] taulu = new float[LuoTaulukko()];

            KysyArvotTaulukkoon(taulu);
            LajitteluTulosta(taulu);
            TulostaTiedot(taulu);


            


        }
            
    }       
}
