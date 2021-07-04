//Exercises from Brackeys series of YouTube videos about C# for begginners

using System;

namespace My_Awesome_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numberGen = new Random(); //Define a number generator
            int roll = 0;
            int attempts = 0;

            Console.WriteLine("Press enter to roll the dice.");

            while(roll != 6)
            {
                Console.ReadKey();//Wait for the user to press the key before doing the loop
                roll = numberGen.Next(1, 7); //(range of numbers - first is inclusive, second is exclusive, so it goes 1 to 6)
                Console.WriteLine("You rolled: " + roll);
                attempts++; 
            }

            Console.WriteLine("It took you " + attempts + " attempts to roll a six!");
            //Wait before closing
            Console.ReadKey();  
        }
    }
}
