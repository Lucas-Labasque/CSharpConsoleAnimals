using CSharpAnimal.Models.Animals;

namespace CSharpAnimal.Models.Animals
{
    class Griffin : Animal, IPilotage
    {
        public Griffin()
        {
            name = "Griffin";
        }
        public Griffin(string name, string type, int ID)
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
    }
}