using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_userInput
{
    class Program
    {
        public static int sum = 0;
        public static List<int> numbers = new List<int>();
        public static int num;

        static void Main(string[] args)
        {
            runFuntion();
        }
        public static void runFuntion()
        {
            Console.WriteLine("Insert whole numbers separated with ENTER.\nENTER to quit.");
            string userInput = Console.ReadLine();
            if (Int32.TryParse(userInput, out num) == true)
            {
                int number = Int32.Parse(userInput);
                numbers.Add(number);
                sum += number;
                runFuntion();
            }
            else if (userInput == "")
            {
                Console.WriteLine("Sum is " + numbers.Sum());
                Console.WriteLine("Max is " + numbers.Max());
                Console.WriteLine("Min is " + numbers.Min());
                Console.ReadLine();
            }
            else if (Int32.TryParse(userInput, out num) == false)
            {
                Console.WriteLine("Input not a whole number!");
                runFuntion();
            }

        }
    }
}
