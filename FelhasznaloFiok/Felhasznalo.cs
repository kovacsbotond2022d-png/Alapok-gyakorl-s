using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelhasznaloFiok
{
    internal class Felhasznalo
    {
        private string jelszo = "123456";

        public string Felhasznalonev { get; set; }

        public void JelszoModositas(string regiJelszo, string ujJelszo)
        {
            if (regiJelszo == jelszo && ujJelszo.Length >= 6)
            {
                jelszo = ujJelszo;
                Console.WriteLine("A jelszó sikeresen módosítva.");
            }
            else
            {
                Console.WriteLine("A jelszó módosítása sikertelen.");
            }
        }
    }
}
