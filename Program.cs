using Animal.Models;
using CSharpAnimal.Models.Animals;
using AnimalModel = CSharpAnimal.Models.Animals;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Le dragon : ");
        AnimalModel.Dragon animal = new Dragon();
        animal.Sleep();
        animal.Moove();
        animal.Fly();

        Console.WriteLine("\nLe Griffin : ");
        AnimalModel.Griffin animal2 = new Griffin();
        animal2.Sleep();
        animal2.Moove();
        animal2.Fly();

        Console.WriteLine("\nL'oiseau : ");
        AnimalModel.Bird animal3 = new Bird();
        animal3.Sleep();
        animal3.Fly();

        Console.WriteLine("\nL'aigle : ");
        AnimalModel.Eagle animal4 = new Eagle();
        animal4.Sleep();
        animal4.Fly();

        Console.WriteLine("\n\n\n\n ");


        Dog dog = new Dog("Loup", "Epic", 10);
        Dragon enderDragon = new Dragon("Ender Dragon", "Legendary", 99);
        Griffin griffin = new Griffin("GriffonDort", "Rare", 5);
        Dragon ptera = new Dragon("Ptera", "Commun", 1);
        Dog wolf = new Dog("Wolf", "Commun", 2);
        Dog ben = new Dog("Ben", "Commun", 20);

        AnimalModel.Animal[] liste = { dog, enderDragon, griffin, ptera, wolf, ben };
        //var result = liste.Where(c => !c.Type.Contains("Rare"));

        //foreach (Animal animaux in result)
        //{
        //    Console.WriteLine(animaux.Name, animaux.Id);
        //}

        IEnumerable<AnimalModel.Animal> listeAnimaux =
            from animaux in liste
            where animaux.Type == "Commun"
            select animaux;

        var sortedliste = listeAnimaux.OrderByDescending(c => c.Id).ToList();



        foreach (AnimalModel.Animal animaux in sortedliste)
        {
            Console.WriteLine(animaux.name);
        }


        //Dog dog1 = new Dog("Loup");
        //Dog dog2 = new Dog("Enzo");
        //Dog dog3 = new Dog("Antoine");
        //Dog dog4 = new Dog("Raphaël");
        //Dog dog5 = new Dog("snow");
        //Dog[] dogs = { dog1, dog2, dog3, dog4, dog5 };
        //IEnumerable<Dog> differentThanSnow =
        //    from dog in dogs
        //    where dog.dogName != "snow"
        //    select dog;


        //Console.WriteLine("\nLes dogs sont : ");


        //foreach (Dog dog in differentThanSnow)
        //{
        //    Console.WriteLine(dog.dogName);
        //}


        Console.ReadLine();
    }
}