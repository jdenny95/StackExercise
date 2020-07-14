using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();

            var min = 0;
            var max = 10;

            for (var i = min; i <= max; i++)
                stack.Push(i);

            for (var i = min; i <= max; i++)
                Console.WriteLine(stack.Pop());

            Console.WriteLine("Please type 'clear' to clear the list or 'exit' to close application.");

            while (true)
            {
                try
                {
                    var input = Console.ReadLine();

                    switch (input.ToLower())
                    {
                        case "clear":
                            stack.Clear();
                            Console.WriteLine("The list has been cleared");
                            Console.WriteLine(stack.Pop()); // To prove that the list has been cleared
                            break;
                        case "exit":
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("I dont know that command. Please type 'clear' to clear the list or 'exit' to close application.");
                            break;
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
