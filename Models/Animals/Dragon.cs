using CSharpAnimal.Models.Animals;

namespace CSharpAnimal.Models.Animals
{
    class Dragon : Animal, IPilotage, IFly
    {
        public Dragon()
        {
            name = "Dragon";
        }

        public Dragon(string name, string type, int ID)
        {
            this.name = name;
            this.Type = type;
            this.Id = ID;
        }
        public override void Moove()
        {
            Console.WriteLine($"{name} moove");
        }

        public new void Sleep()
        {
            Console.WriteLine($"{name} sleep");
        }

        public void Fly()
        {
            Console.WriteLine($"{name} fly");
        }
    }
}