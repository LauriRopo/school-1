using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;

namespace ConsoleApp4
{
    internal class Program

    {
        /* T6 KT3
         * */
        static void Luejatulosta()
        {
            
            StreamWriter sw = new StreamWriter("c:\\temp\\teksti.txt");
            

            sw.WriteLine();

            sw.Close();
        }
        static void Main(string[] args)
        {
            string t;
            Console.WriteLine("Kirjoita jotain");
            t = Console.ReadLine();
            if ( args.Length == 0)
            {
                Console.WriteLine("Parametrejä on 0");
            }
            else
            {
                Luejatulosta();
            }
        }
    }
}
