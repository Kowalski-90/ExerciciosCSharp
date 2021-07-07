//Exercises from Brackeys series of YouTube videos about C# for begginners

using System;

namespace My_Awesome_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numberGen1 = new Random(); //Define a number generator
            Random numberGen2 = new Random();

            int roll1 = 0;
            int roll2 = 1; //Can't be zero because the program will start with the two of a kind already
            int attempts = 0;

            Console.WriteLine("Press enter to roll the dice.");

            while(roll1 != roll2)
            {
                Console.ReadKey(); //Wait for the user to press the key before doing the loop
                
                roll1 = numberGen1.Next(1, 7); 
                roll2 = numberGen2.Next(1, 7);
                Console.WriteLine("Roll 1: " + roll1);
                Console.WriteLine("Roll 2: " + roll2 + "\n");
                attempts++; 
            }

            Console.WriteLine("It took you " + attempts + " attempts to roll two of a kind");
            
            //Wait before closing
            Console.ReadKey();  
        }
    }
}
