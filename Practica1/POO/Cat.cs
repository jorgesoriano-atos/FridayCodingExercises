using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.POO
{
    internal sealed class Cat : Animal
    {
        protected internal override bool HasFur { get; set; }
        protected internal override int LegNumber { get; set; }

        protected internal override string Name { get; set; }
        

        private string FavouriteFood { get; set; }
        private bool HasEaten { get; set; }
        private double Weight { get; set; }

        public Cat(bool hasFur, string name)
        {
            HasFur = hasFur;
            Name = name;
            LegNumber = 4;
            HasEaten = false;
            FavouriteFood = "fish";
            Weight = 3.5;
        }

        protected internal override void Eat()
        {
            if (!HasEaten)
            {
                Hunt();
                Console.WriteLine($"\n\t{Name} says: Om nom nom... fishies!");
                Weight += 0.2;

            } else
            {
                Console.WriteLine($"\n\t{Name} says: I'm not hungry right now.");
            }
        }

        protected internal override void Sleep()
        {
            HasEaten = false;
            Console.WriteLine($"\n\t{Name} says: ZzZzZz...");
        }

        public void Hunt()
        {
            Weight -= 0.1;
            Console.WriteLine($"\n\t{Name} is hunting...");
        }

        public double GetWeight()
        {
            return Weight;
        }

    }
}
