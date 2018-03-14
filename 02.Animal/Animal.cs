﻿using System;
using System.Collections.Generic;
using System.Text;

public abstract class Animal
{
    public Animal(string name, string favouriteFood)
    {
        this.Name = name;
        this.FavouriteFood = favouriteFood;
    }
    public string Name { get; protected set; }
    public string FavouriteFood { get; protected set; }

    public virtual string ExplainSelf()
    {
        var result = $"I am {this.Name} and my fovourite food is {this.FavouriteFood}";
        return result;
    }
}


