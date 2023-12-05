using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp3
{
    internal class Program
    {
        /* t4 kt4
         * Lotossa arvotaan seitsemän (7) varsinaista numeroa ja yksi (1) lisänumero.
         * Numerot ovat väliltä 1-40.
         * Esittele kahdeksan (8) alkioinen lotto-taulukko ja arvo siihen lottonumerot.
         * (7 ensimmäistä on siis varsinaisia lottonumeroita ja viimeinen on lisänumero).
         *  Muista, että samaa numeroa ei saa tulla lottoriviin eli mieti miten voisit tarkistaa onko arvottu numero jo
         *  lottorivissä entuudestaan ja silloin sen tilalle pitää arpoa uusi numero.
         *  Tulosta lopuksi lottorivi seuraavasti:
         *  1  4  12  16  19  25  31  +  13
         *  HUOM!! seitsemän varsinaista numeroa on lajiteltu suuruusjärjestykseen! 
         *  Mutta lisänumeroa ei tietenkään saa ottaa lajitteluun mukaan!
         * 
         * Array.Sort(ftaulu, 0, 3);
         */

        static void Main()
        {
            
            int[] itaulu = new int[8];
            Random rnd = new Random();
            int luku, i, index;
            

            for (i = 0; i < itaulu.Length;i++)
            {
                itaulu[i] = rnd.Next(1, 41);
                do
                {
                    itaulu[i] = rnd.Next(1, 41);
                    index = Array.IndexOf(itaulu, itaulu[i]);

                } while (index != i);
            }
            // Järjestetään munerot
            Array.Sort(itaulu, 0, (itaulu.Length - 1));

            for (i = 0; i < itaulu.Length-1; i++)
            {
                Console.Write(itaulu[i] + " ");
            }
            Console.Write("+ " + itaulu.Last());
            Console.WriteLine();




        }

    }       
}
