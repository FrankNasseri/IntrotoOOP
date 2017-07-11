﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntrotoOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //When we initialize a new object, it is called INSTANTIATING (creating a new instance)
            //An object needs to be instantiated before it can be used
            //All objects of a specific type are created from the same templated, called a class
            //All objects from a class will have the same number and type of states, but each instance can have its own unique value.


            //The format we use to instantiate an object looks like this:
            //ClassName objectName = new ClassName();
            Cat firstCat = new Cat();

            firstCat.Name = "Mittens";
            //Console.WriteLine(firstCat.Age);

            Cat secondCat = new Cat("Oz", 3, "Orange and white");
            secondCat.Name = "Ozzy";
            Console.WriteLine(secondCat.Name);
            Console.WriteLine(secondCat.Age);
            secondCat.Eat();


            Dog firstDog = new Dog("Long", 2 + "feet", 20 + "mph", 32 + "lbs");

            //To creat a new object, we use a special method called a CONSTRUCTOR

            //Thinking about objects in real life, create (eith hand-written or type)
            //Three examples of ojects. Your objects should have five states (characteristics) and five behaviors
        }
    }
}
