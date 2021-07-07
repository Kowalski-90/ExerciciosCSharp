using System;

namespace My_Awesome_Program
{
    class Program
    {
        static void Main(string[] args)
        {                       
            Console.WriteLine("Put in your phrase");

            string str = Console.ReadLine();

            Console.WriteLine("There are " + StrLenght(str) + " words in that sentence.");

            //Wait before closing
            Console.ReadKey();
        }

        static int StrLenght(string str)
        {
            int lenght = str.Split(' ').Length;
            return lenght;
        }     
    }
}
