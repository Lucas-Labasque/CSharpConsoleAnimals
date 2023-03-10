
using CSharpAnimal.Models.Animals;

class Program
{
    static void Main(string[] args)
    {
        Animal animal = new Dragon();
        animal.Sleep();
        animal.Moove();

        Animal animal2 = new Griffin();
        animal2.Sleep();
        animal2.Moove();



        Dog dog = new Dog("Loup", "Epic", 10);
        Dragon enderDragon = new Dragon("Ender Dragon", "Legendary", 99);
        Griffin griffin = new Griffin("GriffonDort", "Rare", 5);
        Dragon ptera = new Dragon("Ptera", "Commun", 1);
        Dog wolf = new Dog("Wolf", "Commun", 2);
        Dog ben = new Dog("Ben", "Commun", 20);

        Animal[] liste = { dog, enderDragon, griffin, ptera, wolf, ben };
        //var result = liste.Where(c => !c.Type.Contains("Rare"));

        //foreach (Animal animaux in result)
        //{
        //    Console.WriteLine(animaux.Name, animaux.Id);
        //}

        IEnumerable<Animal> listeAnimaux =
            from animaux in liste
            where animaux.Type == "Commun"
            select animaux;

        var sortedliste = listeAnimaux.OrderByDescending(c => c.Id).ToList();



        foreach (Animal animaux in sortedliste)
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