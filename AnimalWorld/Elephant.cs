using System;

namespace AnimalWorld
{
    class Elephant : IAnimals
    {
        private int Weight { get; } = 8000;
        private int Quantity { get; } = 5;
        private string Color { get; } = "Gray";

        public void Show()
        {
            Console.WriteLine($"Elefant:\n Weight: {Weight},\n Quantity: {Quantity},\n Color: {Color}");
        }
    }
}