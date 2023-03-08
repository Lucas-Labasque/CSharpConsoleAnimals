using System;
using System.Runtime.ConstrainedExecution;
using Animal.Models.Animals;

public class Program
{
    // Définition de la méthode Main
    public static void Main()
    {
        // Instanciation classe Griffin
        Griffin griffin = new Griffin();
        Griffin griffin2 = new Griffin();

        Dragon dragon = new Dragon();
        Dragon dragon2 = new Dragon();


        griffin.Name = "Antoine";
        griffin2.Name = "Evan";

        // A nom de chaque animal
        Console.WriteLine("Animal 1 : " + griffin.Name);
        Console.WriteLine("Animal 2 : " + griffin2.Name);
        Console.WriteLine("Animal 3 : " + dragon.Name);
        Console.WriteLine("Animal 4 : " + dragon2.Name);
        
        // Appel des méthodes 
        griffin.Move();
        griffin.Sleep();
        griffin2.Move();
        griffin2.Sleep();
    }
}
