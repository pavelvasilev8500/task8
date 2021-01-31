using System;

namespace AnimalWorld
{
    class Gibbon : IAnimals
    {
        private int Quantity { get; set; } = 3;
        private string Color { get; set; } = "Dark brown";

        public void Show()
        {
            Console.WriteLine($"Gibbon:\n Quantity: {Quantity},\n Color: {Color}");
        }
    }
}