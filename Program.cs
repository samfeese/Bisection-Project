using System;

namespace Bisection
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Press Enter to Start");
            var input = Console.ReadKey();
            do
            {
                UserInterface ui = new UserInterface();
                ui.Start();
                Console.WriteLine("Press Enter to try again or ESC to quit");
                input = Console.ReadKey();


            } while (input.Key == ConsoleKey.Enter);
        }
    }
}
