using System;
using System.Collections.Generic;


namespace Stack_exercise
{


    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();


            while (true)
            {
                string input = Console.ReadLine();

                if (input.Contains("Pop"))
                {
                    stack.Pop();
                }

                else if (input.Contains("Push"))
                {
                    var popped_element = input.Substring(4);
                    stack.Push(popped_element);
                }

                else if (input.Contains("Clear"))
                {
                    stack.Clear();
                    Console.WriteLine("All elements in stack is cleared !");

                }
                else
                {
                    Console.WriteLine("Please operate a valid operation onto stack !");
                }

            }

        }
    }
}
