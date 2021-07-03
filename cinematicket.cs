using System;

namespace My_Awesome_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! Tickets are US$ 5. Please insert cash");

            int cash = Convert.ToInt32(Console.ReadLine());

            if(cash < 5)
            {
                Console.WriteLine("That's not enough money");
            }
            else if (cash == 5)
            {
                Console.WriteLine("Here is your ticket");
            }
            else
            {
                int change = cash -5;
                Console.WriteLine("Here is your ticket and " + change + " dollars in change");
            }

            //Wait before closing
            Console.ReadKey();  
        }
    }
}
