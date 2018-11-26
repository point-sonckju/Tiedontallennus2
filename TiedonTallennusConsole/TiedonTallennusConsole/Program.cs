using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace TiedonTallennusConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string tiedosto = "C:\\Temp\\Lämpötila.txt"; //tai @"C:\Temp\Lämpötila.txt";

           NumberFormatInfo nfi = new CultureInfo("fi-FI", false).NumberFormat;
           Console.WriteLine(nfi.NumberDecimalDigits);

            //Luetaan aiemmin asetettu lämpötila
            if (File.Exists(tiedosto))
            {
                string aiempiarvo = File.ReadAllText(tiedosto);
                Console.WriteLine("Aiemmin asetettu teksti oli tämä: " + aiempiarvo);
            }
            else
            {
                Console.Write("Tervetuloa sovellukseen - ");
            }
            //decimal lämpötila;
            string teksti;
            Console.Write("Anna uusi teksti: ");
            teksti = Console.ReadLine();
            //lämpötila = decimal.Parse(syöte);
            //Tiedostoon

            File.AppendAllText(tiedosto, teksti+"\r\n");
            Console.WriteLine("Uusi teksti on tallennettu!");
            Console.ReadLine();


        }
    }
}
