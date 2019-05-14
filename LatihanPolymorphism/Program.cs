using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Speak();

            Cat cat = new Cat();
            //cat.Speak();\
            animal = cat;
            animal.Speak();

            Chicken chicken = new Chicken();
            //chicken.Speak();
            animal = chicken;
            animal.Speak();

            Dog dog = new Dog();
            //dog.Speak();
            animal = dog;
            animal.Speak();

            Console.ReadKey();
        }
    }
}
