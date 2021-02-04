using System;

namespace AnimalWorld
{
    class Monkey : IAnimal, IShowAnimal
    { 
        private string Food { get; } = "Bananas";
        private string Color { get; } = "Broun";
        private int Quantity { get; } = 4;
        private int Lifespan { get; } = 40;
        private int Growth { get; } = 1;

        public void Sleep()
        {
                Console.WriteLine(" At 12pm monkeys are alrady sleep;");
        }

        public void Walk()
        {
                Console.WriteLine(" At 1pm Monkeys are walking;");
        }

        public void Info()
        {
            Console.WriteLine($" Food : {Food},\n Color : {Color},\n Quantity : {Quantity},\n Lifespan : {Lifespan},\n Growth : {Growth}");
        }

        public void Show()
        {
            Console.WriteLine("Monkey:");
            Info();
            Sleep();
            Walk();
            Console.WriteLine("");
        }
    }
}