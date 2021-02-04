using System;

namespace AnimalWorld
{
    class Giraffe : IAnimal, IShowAnimal
    {
        private int Height { get; } = 5;
        private int Quantity { get; } = 2;
        private string Color { get; } = "Orange-yellow";
        private string Food { get; } = "Аcacia";

        public void Sleep()
        {
            Console.WriteLine(" Giraffe sleep at night");
        }

        public void Walk()
        {
            Console.WriteLine(" Giraffe walk at daytime");
        }

        public void Info()
        {
            Console.WriteLine($" Food : {Food},\n Height : {Height},\n Quantity : {Quantity},\n Color : {Color}");
        }

        public void Show()
        {
            Console.WriteLine("Giraffe:");
            Info();
            Sleep();
            Walk();
            Console.WriteLine("");
        }
    }
}