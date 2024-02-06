using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Nara_P
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public int Age { get; set; }
        
        public Animal() 
        { 
        }

        public abstract void Eat();

        public override string ToString()
        {
            return $"The name of the animal is: {Name}\n" +
                $"{Name}'s color is: {Colour}\n" +
                $"{Name}'s age is: {Age}years old";
        }



    }
}
