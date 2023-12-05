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
            /* Teema 2 KT 2.
             Kysy käyttäjältä kuukauden numero. Tulosta sen jälkeen onko nyt syksy, talvi,
            kevät vai kesä. Käytä switch-case rakennetta.
            */

            int iluku;

            Console.Write("Kuukauden numero : ");
            iluku = int.Parse(Console.ReadLine());

            switch(iluku)
            {


                case 1:
                    Console.Write("On talvi \n");
                    break;
                case 2:
                    Console.Write("On talvi \n");
                    break;
                case 3: 
                    Console.Write("On kevät \n");
                    break;
                case 4:
                    Console.Write("On kevät \n");
                    break;
                case 5:
                    Console.Write("On kevät \n");
                    break;
                case 6:
                    Console.Write("On kesä \n");
                    break;
                case 7:
                    Console.Write("On kesä \n");
                    break;
                case 8:
                    Console.Write("On syksy \n");
                    break;
                case 9:
                    Console.Write("On syksy \n");
                    break;
                case 10:
                    Console.Write("On syksy \n");
                    break;
                case 11:
                    Console.Write("On talvi \n");
                    break;
                case 12:
                    Console.Write("On talvi \n");
                    break;
            }
            


            

                
            

        }
    }
}
