using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp3
{
    internal class Program
    {
        /* t4 kt3
         * Lue käyttäjältä pitkähkö teksti string muuttujaan.
         * 1. Muuta kaikki kirjaimet isoiksi kirjaimiksi ja tulosta muutettu teksti.
         * 2. Korvaa kaikki isot A kirjaimet huutomerkillä ja tulosta teksti.
         * 3. Poista kaikki välilyönnit ja tulosta teksti
         * 4. Tulosta lopuksi kaikki merkit lopusta alkuun yhdellä välilyönnillä eroteltuna
         *  
         * 
         */

        static void Main()
        {


            string sTeksti;

            Console.WriteLine("Kirjoita tekstiä : ");
            sTeksti = Console.ReadLine();
            Console.Clear();

            // Muutetaan kirjaimet isoiksi.
            sTeksti = sTeksti.ToUpper();
        
            Console.WriteLine("1. {0}",sTeksti);

            // Muutetaan kaikki "A" huutomerkeiksi
            sTeksti = sTeksti.Replace('A', '!');

            Console.WriteLine("2. {0}",sTeksti);

            // Poistetaan kaikki välilyönit
            sTeksti = sTeksti.Replace(" ", "");
       
            Console.WriteLine("3. {0}",sTeksti);

            // Tulostetaan teksti väärinpäin yhdellä välilyönillä erotettuna
            char[] cArray = sTeksti.ToCharArray();
            string reverse = String.Empty;

              for (int i = cArray.Length - 1; i > -1; i--)
              {
                  reverse += cArray[i];
              }
               Console.WriteLine("4. {0}",reverse);







































        }

    }       
}
