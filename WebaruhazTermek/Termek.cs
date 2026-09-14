using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebaruhazTermek
{
    internal class Termek
    {
        public string Nev { get; set; }

        private int egysegar;
        public int Egysegar
        {
            get { return egysegar; }
            set
            {
                if (value < 1)
                    egysegar = 1;
                else
                    egysegar = value;
            }
        }

        private int keszlet;
        public int Keszlet
        {
            get { return keszlet; }
            set
            {
                if (value < 0)
                    keszlet = 0;
                else
                    keszlet = value;
            }
        }
    }
}
