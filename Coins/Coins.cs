using System;
using System.Collections.Generic;

namespace Coins.Models
{
    public class CoinsClass
    {
        public int Quarters { get; set; }
        public int Dimes { get; set; }
        public int Nickels { get; set; }
        public int Pennies { get; set; }

        public CoinsClass()
        {
            Quarters = 0;
            Dimes = 0;
            Nickels = 0;
            Pennies = 0;
        }
        public void ConvertToQuarters(double userInput)
        {
            if (userInput >= .25)
            {
                double quartersAmount = Math.Floor(userInput / .25);
                this.Quarters += (int)quartersAmount;
                double quartersRemainder = userInput % .25;
                ConvertToDimes(quartersRemainder);
            }
            else
            {
                ConvertToDimes(userInput);
            }
        }
        public void ConvertToDimes(double userInput)
        {
            if (userInput >= .10)
            {
                double dimesAmount = Math.Floor(userInput / .10);
                this.Dimes += (int)dimesAmount;
                double dimesRemainder = userInput % .10;
                ConvertToNickles(dimesRemainder);
            }
            else
            {
                ConvertToNickles(userInput);
            }
        }
        public void ConvertToNickles(double userInput)
        {
            if (userInput >= .05)
            {
                double nickelsAmount = Math.Floor(userInput / .05);
                this.Nickels += (int)nickelsAmount;
                double nickelsRemainder = userInput % .05;
                this.Pennies += (int)nickelsRemainder;
            }
            else
            {
                this.Pennies += (int)userInput;
            }
        }
    }
}