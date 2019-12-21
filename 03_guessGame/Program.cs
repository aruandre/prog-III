using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_guessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int secretNum = Newnum(1, 51);
                int count = 1;
                while (true)
                {
                    Console.Write("enter a number between 1 and 50(0 to quit): ");
                    int input = Convert.ToInt32(Console.ReadLine());
                    if (input == 0)
                        return;
                    else if (input < secretNum)
                    {
                        Console.WriteLine("guessed number too low");
                        ++count;
                        continue;
                    }
                    else if (input > secretNum)
                    {
                        Console.WriteLine("guessed number too high");
                        ++count;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("correct! secret number was {0}!", secretNum);
                        Console.WriteLine("tt took you {0} {1}.\n", count, count == 1 ? "try" : "tries");
                        break;
                    }
                }
            }

        }
        static int Newnum(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
