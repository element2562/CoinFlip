using System;

namespace CoinFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CoinFlip(8));
        }
        //Main goal is to find out the most amount of times each side was landed on in a row
        static string CoinFlip(int amountOfFlips)
        {
            int headsMax = 0;
            int tailsMax = 0;
            int headsCounter = 0;
            int tailsCounter = 0;
            Random random = new Random();
            for(int i = 0; i < amountOfFlips; i++)
            {
                var index = Math.Round(random.NextDouble());
                if(index == 0)
                {
                    headsCounter++;
                    if(tailsCounter > tailsMax)
                    {
                        tailsMax = tailsCounter;
                    }
                    tailsCounter = 0;
                }
                else
                {
                    tailsCounter++;
                    if(headsCounter > headsMax)
                    {
                        headsMax = headsCounter;
                    }
                    headsCounter = 0;
                }
            }
            return $"Heads was landed on a maximum of {headsMax} times in a row and tails was landed on a maximum of {tailsMax} times in a row in {amountOfFlips} flips.";
        }
    }
}
