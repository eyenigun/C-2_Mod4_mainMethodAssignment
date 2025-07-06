using System;
using C_2_Mod4_mainMethodAssignment;

namespace DivideByTwoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the class
            Devidebytwo divider = new Devidebytwo();

            // Get user input
            Console.Write("Enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            // Call the method
            divider.DivideByTwo(input);

            Console.ReadLine(); // Pause to view result

            // 2nd assignment

            // Instantiate the class
            //MathMethods method = new MathMethods();

            // Ask user for input
            Console.Write("Enter an integer: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            // Call Method1
            int result1 = MathMethods.Method1(userInput);
            Console.WriteLine("Method1 result (int * int): " + result1);

            // Call Method2
            int result2 = MathMethods.Method2(userInput);
            Console.WriteLine("Method2 result (int * int - 1): " + result2);

            // Call Method3
            int result3 = MathMethods.Method3(userInput);
            Console.WriteLine("Method3 result (int * int + 1): " + result3);

            Console.ReadLine(); // Pause to view output
        }
    }
}
