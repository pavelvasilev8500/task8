using System;

namespace AnimalWorld
{
    class Elephant : IAnimal, IShowAnimal
    {
        private int Weight { get; } = 8000;
        private int Quantity { get; } = 4;
        private int Lifespan { get; } = 75;
        private string Color { get; } = "Gray";
        private string Food { get; } = "Grass";
        private string Type { get; } = "African";

        public void Sleep()
        {
            Console.WriteLine(" Elefants are redy to sleep at 10pm;");
        }

        public void Walk()
        {
            Console.WriteLine(" Elefants are walking;");
        }

        public void Info()
        {
            Console.WriteLine($" Type : {Type},\n Food : {Food},\n Weight : {Weight},\n Quantity : {Quantity},\n Color: {Color},\n Lifespan : {Lifespan}");
        }

        public void Show()
        {
            Console.WriteLine("Elefant:");
            Info();
            Sleep();
            Walk();
            Console.WriteLine("");
        }
    }
}