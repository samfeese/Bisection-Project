using System;
using System.Collections.Generic;
using System.Text;

namespace Bisection
{
    class UserInterface
    {
        ComputerPlay computer = new ComputerPlay();
        HumanPlay human = new HumanPlay();
        public void Start()
        {
            Console.WriteLine("Welcome to the Bi-Section guessing game");
            Console.WriteLine("\nF1: Pick a number and have the computer guess || F2: Guess a computer generated number.");


            var input = Console.ReadKey();
            switch (input.Key)
            {
                case ConsoleKey.F1:
                    computer.UserNumberPick();
                    break;
                case ConsoleKey.F2:
                    human.PlayBounds();
                    break;
                default:
                    Start();
                    break;
                
            }

        }

    }
}
