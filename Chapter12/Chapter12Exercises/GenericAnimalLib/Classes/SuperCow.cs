﻿using static System.Console;

namespace GenericAnimalLib.Classes
{
    public class SuperCow : Cow
    {
        public SuperCow(string newName) : base(newName) { }

        public SuperCow() { }

        public void Fly() => WriteLine($"{name} is flying");

        public override void MakeANoise() => WriteLine($"{name} says 'Here I come to save the day!'");
    }
}
