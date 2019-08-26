using System;
using System.Collections.Generic;
using System.Text;

namespace Bisection
{
    class HumanPlay
    {
        public static int lowerBound = 0;
        public static int upperBound = 100;
        public static int generatedNumber; 

        public void PlayBounds()
        {
            Console.WriteLine("Press F1 to play between 0-100 || Press F2 to set your own bounds to play in.");

            var input = Console.ReadKey();
            switch (input.Key)
            {
                case ConsoleKey.F1:
                    
                    generatedNumber = PickNumber.RandomInt();
                    Play();
                    break;
                case ConsoleKey.F2:
                    SetBounds();
                    Play();
                    break;
                default:
                    break;

            }
        }
        private void SetBounds()
        {
            Console.Clear();
            Console.WriteLine("Specify yout bounds of play:");
            Console.Write("Lower Limit: ");
            lowerBound = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Upper Limit: ");
            upperBound = int.Parse(Console.ReadLine());

            generatedNumber = PickNumber.SpecifiedInt();

            Console.WriteLine();
        }
        public void Play()
        {
            int counter = 0;
            int input;
            do
            {
                counter++;
                Console.Write("Guess a number: "); input = int.Parse(Console.ReadLine()); Console.WriteLine();
                if (input > generatedNumber)
                {
                    Console.WriteLine("The number you chose is High");

                }
                else if (input < generatedNumber)
                {
                    Console.WriteLine("The number you chose is Low");
                }
                else if (input == generatedNumber)
                {
                    Console.WriteLine($"Congratulations you guessed the number! It took you {counter} guesses.");
                }

            } while (input != generatedNumber);
        }
    }
}
