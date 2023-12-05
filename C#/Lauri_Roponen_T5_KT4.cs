using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp3
{
    internal class Program
    {
        /* T5 KT4
        tee ohjelma, joka tulostaa ensin tiedon siitä, kuinka monta parametria Main-funktioon tuli.
        Lisäksi jos ensimmäisen parametri oli "opettaja" niin tulosta "Koita saada oppilaat oppimaan", 
        jos se taas oli "opiskelija", niin tulosta "koita opiskella ahkerasti". Jos se oli jotain muuta, niin tulosta "en ymmärrä"


      */





        static void Main(string[] args)
        {
            int i;
            for (i = 0; i < args.Length; i++) {
                Console.WriteLine("Parametreja tuli {0} kpl", args.Length);

                if (args[i] == "opettaja")
                {
                    Console.WriteLine("Koita saada oppilaat oppimaan");

                }
                else if (args[i] == "oppilas") 
                {
                    Console.WriteLine("Koita opiskella ahkerasti");
                }
                else
                {
                    Console.WriteLine("En ymmärrä");
                }
            }
        }    
    }       
}
