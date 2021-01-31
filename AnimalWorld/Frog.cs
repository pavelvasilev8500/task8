using System;

namespace AnimalWorld
{
    class Frog : IAnimals
    {
        private int Quantity { get; } = 10;
        private string Color { get; } = "Green";

        public void Show()
        {
            Console.WriteLine($"Frog:\n Quantity: {Quantity},\n Color: {Color}");
        }
    }
}