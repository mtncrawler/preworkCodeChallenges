using System;

namespace codeChallenges
{
    class Program
    {
        static void Main(string[] args)
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

    }
}