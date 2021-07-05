using System;

namespace My_Awesome_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("How many students are in your class: ");
            
            int students = Convert.ToInt32(Console.ReadLine());
            string[] Students = new string[students];
            
            Console.WriteLine("Type in their names: ");

            for (int i = 0; i < Students.Length; i++)
            {
                Students[i] = Console.ReadLine();
            }

            Console.WriteLine("\nHere they are alphabetically");
            Array.Sort(Students);

            for (int i = 0; i < Students.Length; i++)
            {
                Console.WriteLine(Students[i]);
            }
            
            //Wait before closing
            Console.ReadKey();  
        }
    }
}
