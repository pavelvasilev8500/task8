using System.Collections.Generic;

namespace AnimalWorld
{
    class Group 
    {
        private void Animals()
        {
            var alist = new List<IShowAnimal>();
            alist.Add(new Monkey());
            alist.Add(new Gibbon());
            alist.Add(new Elephant());
            alist.Add(new Giraffe());
            alist.Add(new Frog());
            alist.Add(new Salamander());
            foreach(IShowAnimal animal in alist)
            {
                animal.Show();
            }
        }

        public void Show()
        {
            Animals();
        }
    }
}