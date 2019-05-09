using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismandInheritance
{
    class Entity1 : Object
    {
        //Data Members
        private string name;
        private string profession;
        private string race;
        private int strength;
        private int constitution;

        //Properties

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if ((value != null) || (value != ""))
                {
                    name = value;
                }
                else
                {
                    name = "Please add a name";
                }
            }
        }

        public string Prof
        {
            get
            {
                return profession;
            }
            set
            {
                switch (value)
                {
                    case "FIGHTER":
                    case "Fighter":
                    case "fighter":
                        profession = value;
                        break;
                    case "MAGE":
                    case "Mage":
                    case "mage":
                        profession = value;
                        break;
                    default:
                        Console.WriteLine("Profession is not known");
                        profession = null;
                        return;
                }
            }
        }

        public int Str
        {
            get
            {
                return strength;
            }
            set
            {
                if ((value >= 3) && (value <= 18))
                {
                    strength = value;
                }
                else
                {
                    strength = 3;
                }
            }
        }

        public int Con { get; set; }


        public string getName() { return name; }
        public string getPro() { return profession; }
        public int getStr() { return strength; }
        public int getCon() { return constitution; }

        public void attack()
        {
            Console.WriteLine("you attack");
        }
    }
}

