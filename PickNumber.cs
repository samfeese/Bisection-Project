using System;
using System.Collections.Generic;
using System.Text;

namespace Bisection
{
    static class PickNumber
    {
        public static int numberPicked;


        static public int RandomInt()
        {
            Random rand = new Random();

            int newNumber = rand.Next(0, 100);
            numberPicked = newNumber;
            return newNumber;
        }
        static public int SpecifiedInt()
        {
            Random rand = new Random();

            int newNumber = rand.Next(HumanPlay.lowerBound, HumanPlay.upperBound);
            numberPicked = newNumber;
            return newNumber;
        }


    }
}
