using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebaruhazTermek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
                Termek termek1 = new Termek();
                termek1.Nev = "monitor";
                termek1.Egysegar = 350000;
                termek1.Keszlet = 15;

                Termek termek2 = new Termek();
                termek2.Nev = "bilentyuzet";
                termek2.Egysegar = -500;   
                termek2.Keszlet = -10;     

                Console.WriteLine("1. termék:");
                Console.WriteLine($"Név: {termek1.Nev}");
                Console.WriteLine($"Egységár: {termek1.Egysegar} Ft");
                Console.WriteLine($"Készlet: {termek1.Keszlet} db");

                Console.WriteLine();

                Console.WriteLine("2. termék:");
                Console.WriteLine($"Név: {termek2.Nev}");
                Console.WriteLine($"Egységár: {termek2.Egysegar} Ft");
                Console.WriteLine($"Készlet: {termek2.Keszlet} db");
            
        }
    }
}
