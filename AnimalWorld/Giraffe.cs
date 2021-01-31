using System;

namespace AnimalWorld
{
    class Giraffe : IAnimals
    {
        private int Height { get; } = 5;
        private int Quantity { get; } = 2;
        private string Color { get; } = "Orange-yellow";

        public void Show()
        {
            Console.WriteLine($"Giraffe:\n Height: {Height},\n Quantity: {Quantity},\n Color: {Color}");
        }
    }
}