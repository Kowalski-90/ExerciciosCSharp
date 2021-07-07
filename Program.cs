using System;

namespace My_Awesome_Program
{
    class Program
    {
        static void Main(string[] args)
        {           
            MeetAlien();            
            Console.WriteLine("-------------");
            MeetAlien();

            //Wait before closing
            Console.ReadKey();
        }

        static void MeetAlien()
        {
            Random numberGen = new Random();
            string name = "X-" + numberGen.Next(10, 9999);
            int age = numberGen.Next(10, 500);

            Console.WriteLine("Hi, I'm " + name);
            Console.WriteLine("I'm " + age + " years old.");
            Console.WriteLine("Oh! And I'm an alien.");
        }
    }
}
