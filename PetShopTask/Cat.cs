using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShopTask;

namespace PetShopTask
{
    internal class Cat
    {
        public string NickName { get; set; }
        public int Age { get; set; }

        public bool IsGender { get; set; }

        public int Energy { get; set; }

        public double Price { get; set; }

        public int MealQuantity { get; set; }
        public void Eat()
        {
            if (MealQuantity == 100)
            {
                Console.WriteLine("mrr I don't want to eat");
            }
            else
            {
                MealQuantity += 10;
                Console.WriteLine("myav I eat");
            }
        }
        public void Sleep()
        {
            if (Energy == 100)
            {
                Console.WriteLine("mrr I don't want to sleep");
            }
            else
            {
                Energy = 100;
                Console.WriteLine("myav I sleep");
            }

        }
        public void Play()
        {
            if (Energy >= 10 && MealQuantity >= 10)
            {
                Console.WriteLine("mrr I play");
                Energy -= 10;
                MealQuantity -= 10;
                
            }
            if (Energy <= 0) {
                Console.WriteLine("myav I go to sleep");
                Sleep(); 
            } 
            if (MealQuantity <= 0) {
                Console.WriteLine("myav I go to eat");
                Eat(); 
            }
           
        }
    }
}
