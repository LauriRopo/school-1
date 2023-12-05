using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lauri_Roponen_KT2.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Esittele muuttujat sEtunimi,sSukunim ja sKokonimi.
             * Lue käyttäjältä nimet ja yhdistä nämä Skokonimi-muuttujaan.
             * Tulosta tyhjälle näytölle nimi sKokonimi-muuttujasta
             */
            
          
            String sEnimi;
            String sSukunimi;
            String sKokonimi;

            Console.WriteLine("Anna etunimi : ");
            sEnimi = Console.ReadLine();
            Console.WriteLine("Anna sukunimi : ");
            sSukunimi = Console.ReadLine();
           
            Console.Clear();
            sKokonimi =  sEnimi  + sSukunimi;

            Console.Write("Nimesi on : {0}",sKokonimi);
            Console.WriteLine("\n");



         

        }
    }
}
