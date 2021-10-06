using System;
using System.Collections.Generic;
using System.Text;

namespace Gambling
{
    class Program
    {
        public const int stake = 100;
        public const int bet = 1;
        public void StartGame()
        {
            int game = stake;
            Random random = new Random();
            int res = random.Next(0, 2);
            if (res == 0)
            {
                game--;

            }
            else
            {
                game++;
            }
            Console.WriteLine(game);
        }
    }
}
