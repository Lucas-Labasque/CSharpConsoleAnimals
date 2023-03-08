using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

public abstract class Animals
{
    public string Name { get; set; }

    // Constructeur
    public Animals()
    {
        this.Name = "Mowgli";
    }

    // Constructeur (Name)      
    public Animals(string name)
    {
        this.Name = name;
    }


    public void SetName(string name)
    {
        this.Name = name;
    }

    // Méthode abstraite Move
    public abstract void Move();

    // Méthode abstraite Sleep
    public abstract void Sleep();
}
