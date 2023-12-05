using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp3
{
    internal class Program
    {
        /* T5 KT2
        Kysy käyttäjältä kuinka iso taulukko luodaan.
        Luo taulukko ja arvo siihen arvosanoja väliltä 0-5. Tutki kuinka moni sai hylätyn arvosanan eli arvosanan 0.
        Tulosta määrä näytölle. Käytä ohjelmassa seuraavia funktioita:

             KysyKoko
             LuoTaulukko
             ArvoArvosanat
             TutkiHylatyt
             Tulosta
          */
        static void KysyKoko(out int akoko)
        {
            Console.WriteLine("Kuinka suuren taulukon haluat luoda : ");
            akoko = int.Parse(Console.ReadLine());

        }
        static void ArvotArvotaan(int[] taulu)
        {
            int i;
            Random r = new Random();

            for (i = 0; i < taulu.Length; i++)
            {
                taulu[i] = r.Next(0, 6);
            }
        }
        static void Tutkihylatyt(int[] taulu)
        {
            foreach(int luku in taulu)
            {
                if(luku == 0)
                {
                    Console.Clear();
                    Console.WriteLine(luku);
                }
            }
            
        }
        static void Main()
        {
            int ikoko;
            int[] taulu;

            KysyKoko(out ikoko);
            taulu = new int[ikoko];
            ArvotArvotaan(taulu);
            Tutkihylatyt(taulu);
            



            










        }
            
    }       
}
