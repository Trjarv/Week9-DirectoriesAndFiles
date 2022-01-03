using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MyShoppingListFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = @"C:\Users\triin\samples\ShoppingList";
            string fileName = @"\\shoppinglist.txt";

            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
            List<string> shoppinglist = arrayFromFile.ToList<string>();

            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Would you like to add to your shopping list? Y/N:");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'y')
                {
                    Console.WriteLine("Enter your wish:");
                    string userWish = Console.ReadLine();
                    shoppinglist.Add(userWish);
                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Have a good day!");
                }
            }
            Console.Clear();

            foreach (string wish in shoppinglist)
            {
                Console.WriteLine($"Your wish: {wish}");
            }
            File.WriteAllLines($"{fileLocation}{fileName}", shoppinglist);
        }
    }
}
