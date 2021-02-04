using System;

namespace AnimalWorld
{
    class Gibbon : IAnimal, IShowAnimal
    {
        private int Lifespan { get; } = 40;
        private int Weight { get; } = 7;
        private int Quantity { get; set; } = 3;
        private string Food { get; } = "Fruits";
        private string Color { get; set; } = "Dark brown";

        public void Sleep()
        {
            Console.WriteLine(" Gibbons are sleep on trees");
        }

        public void Walk()
        {
            Console.WriteLine(" Gibbons start walk at 10am");
        }

        public void Info()
        {
            Console.WriteLine($" Food : {Food},\n Lifespan : {Lifespan},\n Weight : {Weight},\n Quantity : {Quantity},\n Color : {Color}");
        }

        public void Show()
        {
            Console.WriteLine("Gibbon:");
            Info();
            Sleep();
            Walk();
            Console.WriteLine("");
        }
    }
}