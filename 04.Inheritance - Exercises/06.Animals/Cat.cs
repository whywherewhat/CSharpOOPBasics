﻿using System;

public class Cat : Animal
{
    public Cat()
    {
    }
    public Cat(string name, int age) : base(name, age)
    {
    }

    public Cat(string name, int age, string gender) : base(name, age, gender)
    {
    }

    public new void ProduceSound()
    {
        Console.WriteLine("Meow meow");
    }
}