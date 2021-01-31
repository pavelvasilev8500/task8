using System;

namespace AnimalWorld
{
    class Monkey : IAnimals
    {
        private int Quantity { get; } = 3;
        private string Color { get; } = "Brown";

        public void Show()
        {
            Console.WriteLine($"Monkey:\n Quantity: {Quantity},\n Color: {Color}");
        }
    }
}