using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismandInheritance
{
    class BarbarianPlayerCharacter : Entity1
    {
        //Data
        private double beserkerMod;

        //Properties
        public double BeserkerMod
        {
            get
            {
                return beserkerMod;
            }
            set
            {
                if ((value >= 5) && (value <= 18))
                {
                    beserkerMod = value;
                }
                else
                {
                    beserkerMod = 3;
                }
            }
        }

        //Method

        public override void attack()
        {
            Console.WriteLine("you beserk with {0} modifier", beserkerMod);
        }

    }
}
