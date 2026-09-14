using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelhasznaloFiok
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                Felhasznalo felhasznalo = new Felhasznalo();

                felhasznalo.Felhasznalonev = "botond";

                Console.WriteLine($"Felhasználónév: {felhasznalo.Felhasznalonev}");

                Console.WriteLine("\nHibás régi jelszó:");
                felhasznalo.JelszoModositas("rosszjelszo", "ujjelszo");

                Console.WriteLine("\nTúl rövid új jelszó:");
                felhasznalo.JelszoModositas("123456", "123");

                Console.WriteLine("\nHelyes módosítás:");
                felhasznalo.JelszoModositas("123456", "titkos123");
            
        }
    }
}
