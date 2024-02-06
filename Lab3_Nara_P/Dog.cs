using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Nara_P
{
    public class Dog : Animal, IAnimal
    {
        public Dog()
        {
        }

        public Dog(string name)
        {
            this.Name = name;
        }



        public override void Eat()
        {
            Console.WriteLine("Dogs eat meat.");
        }

        //from interface IAnimal
        public string IName{ get; set; }
        public string IColour { get; set; }
        public double IHeight { get; set; }
        public int IAge { get; set; }


        public void Cry()
        {
            Console.WriteLine("Woof!");
        }


    }
}

