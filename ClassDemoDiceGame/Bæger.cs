using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoDiceGame
{
    public class Bæger
    {
        // Properties (måske bedre som instans felter)
        public Die die1 { get; set; }
        public Die die2 { get; set; }

        // metode
        public bool Ryst()
        {
            die1.Slå();
            die2.Slå();

            int terning1Value = die1.VisAntalØjne();
            int terning2Value = die2.VisAntalØjne();

            int sum = terning1Value + terning2Value;

            return sum == 7;
        }

        // konstruktør
        public Bæger()
        {
            die1 = new Die();
            die2 = new Die();
        }

    }
}
