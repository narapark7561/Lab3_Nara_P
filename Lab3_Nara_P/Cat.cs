using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Nara_P
{
    public class Cat : Animal, IAnimal
    {
        public Cat() 
        { 
        }

        public Cat(string name)
        {
            this.Name = name;
        }

        public override void Eat()
        {
            Console.WriteLine("Cats eat mice.");
        }

        //from interface IAnimal
        public string IName { get; set; }
        public string IColour { get; set; }
        public double IHeight { get; set; }
        public int IAge { get; set; }


        public void Cry()
        {
            Console.WriteLine("Meow!");
        }

    }
}
