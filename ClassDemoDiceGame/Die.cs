using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoDiceGame
{
    public class Die
    {
        // til intern brug
        // instans felt
        private static Random _rnd = new Random(DateTime.Now.Millisecond);


        // property
        public int AntalØjne { get; set; }

        // metoder
        public void Slå()
        {
            // slå 
            AntalØjne = _rnd.Next(1, 7);
        }

        public int VisAntalØjne()
        {
            return AntalØjne;
        }

        // konstruktør
        public Die()
        {

        }

    }
}
