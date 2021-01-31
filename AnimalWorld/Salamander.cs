using System;

namespace AnimalWorld
{
    class Salamander : IAnimals
    {
        private int Quantity { get; } = 3;
        private string Color { get; } = "Bright orange ";

        public void Show()
        {
            Console.WriteLine($"Salamander:\n Quantity: {Quantity},\n Color: {Color}");
        }
    }
}