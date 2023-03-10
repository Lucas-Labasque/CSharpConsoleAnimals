using System.Xml.Linq;
using AnimalModel = CSharpAnimal.Models.Animals;


namespace CSharpAnimal.Models.Animals
{

    class Eagle : AnimalModel.Animal, IFly
    {
        public override void Sleep()
        {
            Console.WriteLine("Sleep");
        }
        public void Fly()
        {
            Console.WriteLine("Fly");
        }


    }
}

