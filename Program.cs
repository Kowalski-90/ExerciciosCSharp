using System;

namespace My_Awesome_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            int result1; 
            int result2; 
            int result3; 
            

            Console.WriteLine("What are the results of the math problems below?");
            Console.WriteLine("15 + 2 * 2 = ");
            result1 = Convert.ToInt32(Console.ReadLine());

            if(result1 == 19)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Wrong!");
            }
            
            Console.WriteLine("20 * 2 / 4 = ");
            result1 = Convert.ToInt32(Console.ReadLine());

            if(result1 == 10)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Wrong!");
            }

            Console.WriteLine("(4 + 3 + 2 + 1) / 2 ");
            result1 = Convert.ToInt32(Console.ReadLine());

            if(result1 == 5)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Wrong!");
            }

            //Wait before closing
            Console.ReadKey();  
        }
    }
}
