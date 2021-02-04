using System;

namespace AnimalWorld
{
    class Frog : IAnimal, IShowAnimal
    {
        private int Quantity { get; } = 10;
        private string Color { get; } = "Green";
        private string Food { get; } = "Insects";
        public void Sleep()
        {
            Console.WriteLine(" Frog sleep in the winter");
        }

        public void Walk()
        {
            Console.WriteLine(" Frogs can walk at night");
        }

        public void Info()
        {
            Console.WriteLine($" Food : {Food},\n Quantity: {Quantity},\n Color: {Color}");
        }

        public void Show()
        {
            Console.WriteLine("Frog:");
            Info();
            Sleep();
            Walk();
            Console.WriteLine("");
        }
    }
}