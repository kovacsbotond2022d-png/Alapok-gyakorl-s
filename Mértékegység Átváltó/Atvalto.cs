using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mértékegység_Átváltó
{
    internal class Atvalto
    {
        
        public double Szorzo;

        
        public static double KmBolMeter(double km)
        {
            return km * 1000;
        }

        
        public double EgyediAtvaltas(double ertek)
        {
            return ertek * Szorzo;
        }
    }
}
