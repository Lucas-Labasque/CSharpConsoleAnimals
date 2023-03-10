using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpAnimal.Models.Animals;

namespace CSharpAnimal.Models.Animals
{
    internal class Dog : Animal
    {
        public Dog(string name, string type, int ID)
        {
            this.name = name;
            this.Type = type;
            this.Id = ID;
        }
    }
}