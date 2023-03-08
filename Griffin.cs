using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

// classe Griffin qui hérite Animals
namespace Animal
{
    public class Griffin : Animals
    {


        // méthode abstraite Move
        public override void Move()
        {
            Console.WriteLine($"{Name} est entrain de marcher.");
        }

        // méthode abstraite Sleep
        public override void Sleep()
        {
            Console.WriteLine($"{Name} est entrain de dormir.");
        }
    }
}
