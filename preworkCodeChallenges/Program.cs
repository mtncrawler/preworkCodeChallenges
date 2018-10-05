using System;

namespace codeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem1();
            //Problem2();
            //Problem3();
        }

        //Problem 1: Array Max Result
        static int[] RandomArray()
        {
            int[] randomNum = new int[5];
            Random nums = new Random();
            for (int i = 0; i < 5; i++)
            {
                randomNum[i] = nums.Next(1, 10);
            }
            return randomNum;
        }

        static int ArrayMaxResult(int[] arrInts, string userValue)
        {
            int counter = 0;
            int num = Int32.Parse(userValue);
            foreach (int number in arrInts)
            {
                if (number == num)
                {
                    counter++;
                }
            }
            return num * counter;
        }

        static void Problem1()
        {
            Console.WriteLine("Welcome to Array Max Result");
            int[] randomArrayOutput = RandomArray();
            Console.WriteLine("[{0}, {1}, {2}, {3}, {4}]",
                randomArrayOutput[0],
                randomArrayOutput[1],
                randomArrayOutput[2],
                randomArrayOutput[3],
                randomArrayOutput[4]);
            Console.Write("Please select a number from the array: ");
            string userValue = Console.ReadLine();
            Console.WriteLine("Your score: " + ArrayMaxResult(randomArrayOutput, userValue));
            Console.ReadLine();
        }

        //Problem 2: Leap Year Calendar

        static string LeapYearCalculator(string userInput)
        {
            int year = Int32.Parse(userInput);
            if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
            {
                return year + " is a leap year!";
            }
            else
            {
                return year + " is not a leap year.";
            }
        }

        static void Problem2()
        {
            Console.WriteLine("Welcome to the Leap Year Calculator");
            Console.Write("Please enter a year in YYYY format: ");
            string userYear = Console.ReadLine();
            Console.WriteLine(LeapYearCalculator(userYear));
            Console.ReadLine();
        }

        //Problem 3: Perfect Sequence

        static string PerfSeq(int[] sequence)
        {
            int sum = 0;
            int product = 1;
            foreach (int num in sequence)
            {
                sum += num;
            }
            foreach (int num in sequence)
            {
                product *= num;
            }
            if (Array.Exists(sequence, ele => ele > 0) && sum == product)
            {
                return "Yes!";
            }
            else
            {
                return "Nope!";
            }
        }
        
        static void Problem3()
        {
            int[] givenSeq = new int[] { 1, 2, 3 };
            Console.WriteLine("Riddle me this, do you think the given sequence [1,2,3] is a perfect sequence?");
            Console.Write("Press Enter to check if you are correct.");
            Console.ReadLine();
            Console.WriteLine(PerfSeq(givenSeq));
            Console.ReadLine();
        }
    }
}