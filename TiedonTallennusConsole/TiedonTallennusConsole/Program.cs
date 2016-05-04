using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiedonTallennusConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string tiedosto = "C:\\Temp\\Lämpötila.txt"; //tai @"C:\Temp\Lämpötila.txt";
            //Luetaan aiemmin asetettu lämpötila
            if (File.Exists(tiedosto))
            {
                string aiempilämpötila = File.ReadAllText(tiedosto);
                Console.WriteLine("Aiemmin asetettu lämpötila oli: " + aiempilämpötila + " astetta");
            }
            else
            {
                Console.Write("Tervetuloa sovellukseen - ");
            }

            int lämpötila = 0;
            Console.Write("Anna uusi lämpötila: ");
            string syöte = Console.ReadLine();
            lämpötila = int.Parse(syöte);
            //Tiedostoon

            File.WriteAllText(tiedosto, lämpötila.ToString());
            Console.WriteLine("Uusi lämpötila on tallennettu!");
            Console.ReadLine();


        }
    }
}
