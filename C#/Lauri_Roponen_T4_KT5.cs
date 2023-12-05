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
        /* t4 kt5
         * Esittele sellainen 2-ulottoinen taulukko, johon voit tallentaa maanantain ja perjantain välisenä aikana neljä mittaustulosta jokaiselta päivältä
         * (mittaustulos on sademäärä milleinä).
         * Lue käyttäjältä nämä mittaustulokset taulukkoon ja
         * tulosta lopuksi jokaisen päivän mittaustulosten keskiarvo seuraavan esimerkin mukaisesti :
         * 
         * Maanantai: 12.0 mm
           Tiistai : 0.0 mm
           Keskiviikko : 1.9 mm
           Torstai : 22.8 mm
           Perjantai: 0.9 mm
          */


        static void Main()
        {

            int i, j;
            double[] rivi = new double[4];
            double[,] taulukko = new double[5, 4];
            string[] paiva = new string[5];

            
            paiva[0] = "Maanantai";
            paiva[1] = "Tiistai";
            paiva[2] = "Keskiviikko";
            paiva[3] = "Torstai";
            paiva[4] = "Perjantai";

            i = 0;  j = 0;

            for (j = 0; j < 4; i++)
            {
                Console.WriteLine("Anna päivälle {0} sademäärät", i + 1, j + 1);
                taulukko[i,j] = int.Parse(Console.ReadLine());

                if(i == 3)
                {
                    j++;
                    i = -1;
                }

            }
            Console.Clear();
            // Tulostetaan taulukko
            for (i = 0; i < taulukko.GetLength(0); i++)
            {
                for(j = 0; j < taulukko.GetLength(1); j++)
                {
                    rivi[j] = taulukko[i, j];
                }
                Console.WriteLine("{0} \t : {1:F1}mm", paiva[i], Math.Round(rivi.Average(), 1));
            }
            












        }
            
    }       
}
