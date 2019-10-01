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
        public void ConvertToQuarters(double userInput0)
        {
            
            int userInput = (int)(userInput0 * 100);

            if (userInput >= 25)
            {
                int quartersAmount = (userInput / 25);
                this.Quarters += quartersAmount;
                int quartersRemainder = userInput % 25;
                ConvertToDimes(quartersRemainder);
            }
            else
            {
                ConvertToDimes(userInput);
            }
        }
        public void ConvertToDimes(int userInput)
        {
            if (userInput >= 10)
            {
                int dimesAmount = (userInput / 10);
                this.Dimes += dimesAmount;
                int dimesRemainder = userInput % 10;
                ConvertToNickels(dimesRemainder);
            }
            else
            {
                ConvertToNickels(userInput);
            }
        }
        public void ConvertToNickels(int userInput)
        {
            if (userInput >= 5)
            {
                int nickelsAmount = (userInput / 5);
                this.Nickels += nickelsAmount;
                int nickelsRemainder = userInput % 5;
                this.Pennies += (nickelsRemainder);
            }
            else
            {
                this.Pennies += (int)(userInput);
            }
        }
    }
}