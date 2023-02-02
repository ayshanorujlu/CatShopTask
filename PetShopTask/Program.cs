using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShopTask;

PetShop shop = new();
Cat cat = new Cat();
shop.CatHouseList.Add(new CatHouse { Name = "Cat Zoo" });
shop.CatHouseList.Add(new CatHouse { Name = "The House of the Cats" });
shop.CatHouseList[0].AddCat(new Cat { NickName = "Chaplin", Age = 1, IsGender = true, Energy = 100, Price = 500, MealQuantity = 100 });
shop.CatHouseList[0].AddCat(new Cat { NickName = "Mary", Age = 2, IsGender = false, Energy = 100, Price = 700, MealQuantity = 100 });

void mainMenu()
{
    Console.Clear();
    Console.WriteLine("1. PetShops");
    Console.WriteLine("2. Add CatHouse");
    Console.WriteLine("0. Exit");

    var key = Console.ReadKey();
    switch (key.Key)
    {
        case ConsoleKey.D1:
        case ConsoleKey.NumPad1:
            ShowCatHouses();
            break;
        case ConsoleKey.D2:
        case ConsoleKey.NumPad2:
            AddCatHouse(); break;
        default:
            break;
    }
}


void AddCatHouse()
{
    Console.Clear();
    Console.WriteLine("Evin Adi: ");
    var name = Console.ReadLine();
    CatHouse house = new() { Name = name };
    shop.CatHouseList.Add(house);
}

void ShowCatHouse(CatHouse house)
{
    Console.Clear();
    Console.WriteLine(house.Name);
    Console.WriteLine("1. Butun pishikler");
    Console.WriteLine("2. pishik elave et");
    var key = Console.ReadKey();
    Console.Clear();


    switch (key.Key)
    {
        case ConsoleKey.D1:
        case ConsoleKey.NumPad1:
            int i = 1;
            foreach (var cat in house.Cats)
            {
                Console.WriteLine($"{i++}: {cat.NickName}");
            }
            Console.WriteLine("Select your choice 1/2/3 : ");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Select your choice :\n 1)Eat\n2)Sleep\n3)Play ");
                int choiceActivity = Convert.ToInt32(Console.ReadLine());
                if (choiceActivity == 1)
                {
                    cat.Eat();
                }
                if (choiceActivity == 2)
                {
                    cat.Sleep();
                }
                if (choiceActivity == 3)
                {
                    cat.Play();
                }
            }
            else if (choice == 2)
            {
                Console.WriteLine("Select your choice :\n 1)Eat\n2)Sleep\n3)Play ");
                int choiceActivity = Convert.ToInt32(Console.ReadLine());
                if (choiceActivity == 1)
                {
                    cat.Eat();
                }
                if (choiceActivity == 2)
                {
                    cat.Sleep();
                }
                if (choiceActivity == 3)
                {
                    cat.Play();
                }
            }
            else if (choice == 3)
            {
                Console.WriteLine("Select your choice :\n 1)Eat\n2)Sleep\n3)Play ");
                int choiceActivity = Convert.ToInt32(Console.ReadLine());
                if (choiceActivity == 1)
                {
                    cat.Eat();
                }
                if (choiceActivity == 2)
                {
                    cat.Sleep();
                }
                if (choiceActivity == 3)
                {
                    cat.Play();
                }
            }
            Console.ReadLine();
            break;
        default: break;
    }
}

void ShowCatHouses()
{
    Console.Clear();
    if (shop.CatHouseCount >= 0)
    {
        int i = 1;
        foreach (var house in shop.CatHouseList)
        {
            Console.WriteLine($"{i++}: {house.Name}");
        }
        Console.WriteLine("enter any key");
        var key = Console.ReadLine();
        if (int.TryParse(key, out int result) && 0 <= result && result < shop.CatHouseCount)
        {
            ShowCatHouse(shop.CatHouseList[result - 1]);
        }
    }
    else Console.WriteLine("Hal Hazirda Cat House yoxdur");
}

while (true)
{
    mainMenu();
}
