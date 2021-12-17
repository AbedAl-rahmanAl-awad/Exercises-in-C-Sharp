using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Inheretence
{
    class Program
    {
        public abstract class Animal
        {
            string animalName;

            public void SetName(string name)
            {

                animalName = name;
            }

            public string GetName()
            {
                return animalName;

            }

            public abstract void Eat();

        }
        public class Dog : Animal
        {
            public override void Eat()
            {
                Console.WriteLine("The Dog " + GetName() + " is Eating\n");
            }
        }


        static void Main(string[] args)
        {
            Console.Write("Enter Dog Name: ");
            string dogname = Console.ReadLine();
            Dog dog1 = new Dog();
            dog1.SetName(dogname);
            dog1.Eat();
            
        }
    }
}
