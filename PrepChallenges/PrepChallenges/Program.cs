using System;

namespace PrepChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayMaxResult();
            LeapYearCalculator();
            PerfectSequence();
            SumOfRows();
        }

        static void ArrayMaxResult()
        {
            Console.WriteLine("Please enter five numbers between one and ten.");
            int[] arr = new int[5];

            for (int i = 0; i<5; i++)
            {
                Console.WriteLine($"Number {i+1} will be");
                string userInput = Console.ReadLine();
                int num = Convert.ToInt32(userInput);
                while (num < 0 || num > 10)
                {
                    userInput = Console.ReadLine();
                    num = Convert.ToInt32(userInput);
                }
                arr[i] = num;
            }

            int score = 0;

            while (score == 0)
            {
                Console.WriteLine("Please select one of the numbers you entered.");
                string Input = Console.ReadLine();
                int number = Convert.ToInt32(Input);

                foreach (int num in arr)
                {
                    if (num == number)
                    {
                        score += num;
                    }
                }

                if (score == 0)
                {
                    Console.WriteLine("Sorry, that wasn't a number you provided!");
                }
            }

            Console.WriteLine($"Congratulations, your score is {score}, thanks for playing!");
        }

        static void LeapYearCalculator()
        {
            Console.WriteLine("Welcome to the leap year calculator, please enter a year");
            string input = Console.ReadLine();
            int year = Convert.ToInt32(input);


            // This probably would have been better as a switch statement...
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        Console.WriteLine($"{year} is a leap year.");
                    } else
                    {
                        Console.WriteLine($"{year} is not a leap year.");
                    }
                } else
                {
                    Console.WriteLine($"{year} is a leap year.");
                }
            } else
            {
                Console.WriteLine($"{year} is not a leap year.");
            }

        }

        static void PerfectSequence()
        {
            Console.WriteLine("Welcome to the perfect sequence calculator, how long would you like your array to be?");
            int arrLength = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[arrLength];

            bool perf = true;
            int sum = 0;
            int prod = 1;

            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine("Please enter a number for your array");
                arr[i] = Convert.ToInt32(Console.ReadLine());

                sum += arr[i];
                prod *= arr[i];

                if (arr[i] < 0)
                {
                    perf = false;
                }
            }
            
            if (perf == false)
            {
                Console.WriteLine("One of your array values was negative, this array is not a perfect sequence.");
            } else if (sum == prod)
            {
                Console.WriteLine("Your array was a perfect sequence!");
            } else
            {
                Console.WriteLine($"Your sum, {sum} does not equal your product, {prod}, so the sequence is not perfect.");
            }
        }

        static void SumOfRows()
        {
            Console.WriteLine("Lets make a matrix! How many arrays would you like in the matrix?");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many integers would you like in each array?");
            int depth = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[length, depth];
            int[] sumArr = new int[length];

            Console.WriteLine($"Your matrix is:");

            for (int i=0; i < length; i++)
            {
                Console.Write("{");

                for (int j = 0; j < depth; j++)
                {
                    int num = new Random().Next(1, 100);
                    matrix[i, j] = num;
                    sumArr[i] += matrix[i, j];

                    Console.Write($"{num}, ");
                }

                Console.Write("}, ");
            }

            Console.WriteLine($"The sums of each are:");
            Console.Write("(");
            foreach (int sum in sumArr)
            {
                Console.Write($"{sum}, ");
            }
            Console.Write(")");
        }
    }
}
