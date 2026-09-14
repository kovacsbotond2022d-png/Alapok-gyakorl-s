using Mértékegység_Átváltó;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mertekegyseg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double meter = Atvalto.KmBolMeter(5);
            Console.WriteLine($"5 km = {meter} m");

            
            Atvalto atvalto = new Atvalto();

            
            atvalto.Szorzo = 2.5;

            
            double eredmeny = atvalto.EgyediAtvaltas(10);
            Console.WriteLine($"10 * {atvalto.Szorzo} = {eredmeny}");

        }
    }
}
