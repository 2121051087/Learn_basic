using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Learn_basic
{
   public class Animal
    {
        public int Legs{ get; }
        public float Weight { get; set; }

        public string nameSpeak { get; }
        public Animal()
        {
            Legs = 4;
            Weight = 2.4f;
        }

        public void showLegs()
        {
          Console.WriteLine( $"Legs:{Legs}");
        }
       
        public void showLegs(int Legs,float Weight )
        {
           
            Console.WriteLine($"Legs :{Legs}");
           
        }
    }
    public class Cat : Animal
    {
        public string Food { get; }
        public string color{ get; }
      
        public Cat()
        {
            color = "Black";
            Food = "Mouse";
            showLegs();
        }
        public string Speak(string nameSpeak)
        {
            return  nameSpeak;
        }

        public void Eat()
        {
            Console.WriteLine(Food);
        }

        public class Dog : Animal
        {
            public string action { get; }
            public string color { get; }
            public Dog()
            {
                action = "Bark";
                color = "white";
            }
        }

    }
}
