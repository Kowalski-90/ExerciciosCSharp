﻿using System;
using System.Collections.Generic; //Here are the lists funcionalities

namespace My_Awesome_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = new List<string>();//List syntax
            
            shoppingList.Add("Dreams");
            shoppingList.Add("Miracles");
            shoppingList.Add("Rainbows");
            shoppingList.Add("Pony");

            for (int i = 0; i < shoppingList.Count; i++) //Lists works with .Count and not .Length
            {
                Console.WriteLine(shoppingList[i]);
            }

            shoppingList.Remove("Dreams"); //Two ways of removing items from the list
            shoppingList.RemoveAt(1);

            Console.WriteLine("---------------");

            for (int i = 0; i < shoppingList.Count; i++) //Lists works with .Count and not .Length
            {
                Console.WriteLine(shoppingList[i]);
            }

            //Wait before closing
            Console.ReadKey();  
        }
    }
}
