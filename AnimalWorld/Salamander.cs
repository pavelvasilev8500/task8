using System;

namespace AnimalWorld
{
    class Salamander : IAnimal, IShowAnimal
    {
        private int Quantity { get; } = 3;
        private string Color { get; } = "Bright orange ";
        private string Food { get; } = "Invertebrates";
        public void Sleep()
        {
            Console.WriteLine(" Salamanders does'n sleep at night");
        }

        public void Walk()
        {
            Console.WriteLine(" Salamanders walk in the mountains");
        }

        public void Info()
        {
            Console.WriteLine($" Food : {Food},\n Quantity: {Quantity},\n Color: {Color}");
        }

        public void Show()
        {
            Console.WriteLine("Salamander:");
            Info();
            Sleep();
            Walk();
            Console.WriteLine("");
        }
    }
}