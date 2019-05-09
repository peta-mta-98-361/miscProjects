using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismandInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Entity1 test = new Entity1();
            test.Name = "Frodo";
            test.Prof = "Thief";
            test.Str = 12;
            test.Con = 12;j
            string name = test.getName();
            string prof = test.getPro();
            int str = test.getStr();
            int con = test.getCon();
            test.attack();
            Console.WriteLine(name);
            Console.WriteLine(prof);
            Console.WriteLine(str);
            Console.WriteLine(con);

            BarbarianPlayerCharacter test2 = new BarbarianPlayerCharacter();
            test2.Name = "Conan";
            test2.Prof = "Barbarian";
            test2.Str = 12;
            test2.Con = 12;
            test2.BeserkerMod = 3;
            string name2 = test2.getName();
            string prof2 = test2.getPro();
            int str2 = test2.getStr();
            int con2 = test2.getCon();
            test2.attack();
            Console.WriteLine(name2);
            Console.WriteLine(prof2);
            Console.WriteLine(str2);
            Console.WriteLine(con2);

        }
    }
}
