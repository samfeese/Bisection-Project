using System;
using System.Threading;

namespace Bisection
{
    class ComputerPlay
    {
        public static int lowerBound;
        public static int upperBound;
        public void UserNumberPick()
        {
            Console.Clear();
            Console.WriteLine("Specify yout bounds of play:");
            Console.Write("Lower Limit: ");
            lowerBound = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Upper Limit: ");
            upperBound = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Alright, Think of a number. This will only work as long as you don't change your Number!");
            Thread.Sleep(2000);
            ComputerOutput();
        }

        private void ComputerOutput()
        {
            Console.Clear();
            int counter = 1;
            bool match = false;

            if (counter == 1)
            {
                int guess = (upperBound + lowerBound) / 2;
                Console.WriteLine($"Is your Number {guess}? Y or N:");
                var input = Console.ReadKey();
                if (input.Key == ConsoleKey.Y)
                {
                    Console.WriteLine("That was too Easy. Lets Play Again.");
                    Console.ReadLine();
                }
                else
                {
                    bool high = true;
                    do
                    {
                        Console.WriteLine("\nIs it High or Low? H or L: ");
                        var highOrLow = Console.ReadKey();
                        if (highOrLow.Key == ConsoleKey.H)
                        {
                            high = true;
                            upperBound = guess;
                        }
                        else if (highOrLow.Key == ConsoleKey.L)
                        {
                            
                            high = false;
                            lowerBound = guess;
                        }
                        else
                        {
                            Console.WriteLine("Restart you entered an Incorrect Key.");
                            ComputerOutput();
                        }
                        
                        counter++;
                        guess = ComputerAlgorithm(high);

                        Console.WriteLine($"\nIs your Number {guess}? Y or N:");
                        input = Console.ReadKey();
                        if (input.Key == ConsoleKey.Y)
                        {
                            Console.WriteLine($"\nThat was too Easy, it only took {counter} guesses. Lets Play Again.");
                            match = true;
                            Console.ReadLine();
                        }


                    } while (match != true);

                }


            }

            




        }
        private int ComputerAlgorithm(bool high)
        {
            if (high == true)
            {
                int guess = (lowerBound + upperBound) / 2;
                return guess;
            }
            else if (high == false && lowerBound + 1 == upperBound)
            {
                int guess = ((lowerBound + upperBound) / 2) + 1;
                return guess;
            }
            else
            {
                int guess = (upperBound + lowerBound) / 2;
                return guess;
            }

        }

    }
}
