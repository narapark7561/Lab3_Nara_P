using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab3_Nara_P
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
            //PART 1: Using abstract class - Ask user for dog's name and print properties and methods
            Console.WriteLine("What is your dog's name?");
            Dog dog = new Dog();
            dog.Name = Console.ReadLine();
            dog.Colour = "Brown";
            dog.Age = 3;

       
            //print dog's name, color and age 
            Console.WriteLine(dog);
            dog.Eat();


            //PART 1: Using abstract class - Ask user for cat's name and print properties and methods
            Console.WriteLine("What is your cat's name?");
            Cat cat = new Cat();
            cat.Name = Console.ReadLine();
            cat.Colour = "Grey";
            cat.Age = 4;


            //print cat's name, color and age 
            Console.WriteLine(cat);
            cat.Eat();



            //PART 2: Using Interface - Ask user for dog's name, height, colour and age
            //added 'I' to each propery name  for each property name to avoid configuration between Animal and IAnimal
            Console.WriteLine("What is your dog's name?");
            Dog dog2 = new Dog();
            dog2.IName = Console.ReadLine();
            Console.WriteLine("What is the height of your dog?");
            dog2.IHeight = double.Parse(Console.ReadLine());
            Console.WriteLine("What is the colour of your dog?");
            dog2.IColour = Console.ReadLine();
            Console.WriteLine("What is the age of your dog?");
            dog2.IAge = int.Parse(Console.ReadLine());


            //print dog's name, height, color and age 
            Console.WriteLine($"The name of the animal is: {dog2.IName}\n" +
                $"{dog2.IName}'s height is: {dog2.IHeight}cm\n" +
                $"{dog2.IName}'s color is: {dog2.IName}\n" +
                $"{dog2.IName}'s age is: {dog2.IAge} years old");

            dog2.Eat();
            dog2.Cry();


            //PART 2: Using Interface - Ask user for cat's name, height, colour and age
            Console.WriteLine("What is your cat's name?");
            Cat cat2 = new Cat();
            cat2.IName = Console.ReadLine();
            Console.WriteLine("What is the height of your cat?");
            cat2.IHeight = double.Parse(Console.ReadLine());
            Console.WriteLine("What is the colour of your cat?");
            cat2.IColour = Console.ReadLine();
            Console.WriteLine("What is the age of your cat?");
            cat2.IAge = int.Parse(Console.ReadLine());

            //print cat's name, height, color and age 
            Console.WriteLine($"The name of the animal is: {cat2.IName}\n" +
                $"{cat2.IName}'s height is: {cat2.IHeight}cm\n" +
                $"{cat2.IName}'s color is: {cat2.IName}\n" +
                $"{cat2.IName}'s age is: {cat2.IAge} years old");


            cat2.Eat();
            cat2.Cry();



            //Create a list called 'animals' and add some animal objects to the list
            List<Animal> animals = new List<Animal>();
  
            animals.Add(new Dog("Chai"));
            animals.Add(new Dog("Sarang"));
            animals.Add(new Dog("Mango"));
            animals.Add(new Dog("Doobie"));
            animals.Add(new Dog("Uram"));
            animals.Add(new Cat("Navi"));
            animals.Add(new Cat("Pudding"));
            animals.Add(new Cat("Jelly"));

            Console.WriteLine($"Names of all the animals:");

            //Using loop to print each name of aniamls.
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Name);
            }
        }
    }
}
