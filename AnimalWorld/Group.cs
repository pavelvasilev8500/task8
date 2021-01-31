using System;
using System.Collections.Generic;

namespace AnimalWorld
{
    class Group : IAnimals
    {
        private void Primates()
        {
            var monkey = new Monkey();
            var gibbon = new Gibbon();
            Console.WriteLine("Primates:");
            monkey.Show();
            gibbon.Show();
        }
        private void Mammalians()
        {
            var elephant = new Elephant();
            var giraffe = new Giraffe();
            Console.WriteLine("Mammalians:");
            elephant.Show();
            giraffe.Show();
        }
        private void Amphibians()
        {
            var salamander = new Salamander();
            var frog = new Frog();
            Console.WriteLine("Amphibians");
            salamander.Show();
            frog.Show();
        }
        public void Show()
        {
            Primates();
            Console.WriteLine("-------------------");
            Mammalians();
            Console.WriteLine("-------------------");
            Amphibians();
        }
    }
}