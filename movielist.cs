//Exercises from Brackeys series of YouTube videos about C# for begginners

using System;

namespace My_Awesome_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] movies = new string[4];

            Console.WriteLine("Type in four movies ");

            for (int i = 0; i < movies.Length; i++)
            {
                movies[i] = Console.ReadLine();
            }            

            Console.WriteLine("\nHere they are alphabetically: ");
            Array.Sort(movies); //Arrange the array in an alphabetically order

            for (int i = 0; i < movies.Length; i++)
            {
                Console.WriteLine(movies[i]);
            }

            //Wait before closing
            Console.ReadKey();  
        }
    }
}
