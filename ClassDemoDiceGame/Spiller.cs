using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoDiceGame
{
    public class Spiller
    {
        // instens felt
        private Bæger _bæger;


        //property
        public String Navn { get; set; }


        // metode
        public bool Spil()
        {
            return _bæger.Ryst();
        }

        // Konstruktør
        public Spiller(String navn)
        {
            Navn = navn;
            _bæger = new Bæger();
        }

    }
}
