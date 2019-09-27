using System;

namespace ImranQuestions
{
    public class Car
    {
        public String color;
       public int foo()
        {
            Console.WriteLine("Far over the misty mountains cold!");
            Console.ReadLine();
            return 1;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Car c1 = new Car();
            Car c2 = c1;

            c1.color = "White";

            Console.WriteLine("COLOR 1 :" + c1.color);
            c2.color = "GREEN";
            Console.WriteLine("COLOR 2 :" + c1.color);
            //Console.ReadLine();
            //Console.WriteLine("Reference 2"+c2);
            Console.ReadLine();
            // We live in Object Oriented highly abstract World


        }
    }


    
}