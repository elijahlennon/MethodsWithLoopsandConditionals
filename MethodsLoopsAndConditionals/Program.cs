using System;

namespace MethodsLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            using System;

namespace MethodsWithLoopsAndConditionals
    {
        class Program
        {
            static void Main(string[] args)
            {
                Threes();

            }
            //Write a method to accept two integers as parameterss and check whether they are equal or not - DONE
            public static bool IsEqual(int a, int b)
            {
                if (a == b)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

            public static void Threes()
            {//Write a method that will print to the console numbers 3 through 999 by 3 each time - DONE
                for (var i = 3; i <= 999; i += 3)
                {
                    Console.WriteLine(i);
                }
            }
            //Write a method that will print
            //to the console all numbers 1000 through -1000 - DONE
            public static void PrintRange(int ceiling, int floor)
            {
                for (int i = 1000; i >= -1000; i--)
                {
                    Console.WriteLine(i);
                }
            }
            //Write a method to check whether a given number is even or odd -DONE
            public static void OddOrEven(int number)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine($"{number} is even.");
                }
                else if (number % != 0)
                {
                    Console.WriteLine($"{number} is odd.");

                }
                else
                {
                    Console.WriteLine($"{number} is neither odd nor even.");
                }
                //Write a method to check whether a given number is positive or negative -DONE
                public static void PositiveOrNegative(int num)
                {
                    if (num > 0)
                    {
                        Console.WriteLine($"{num} is positive.");
                    }
                    else if (num < 0)
                    {
                        Console.WriteLine($"{num} is negative.");

                    }
                    else
                    {
                        Console.WriteLine($"{num} is neither positive or negative.");
                    }
                    public static void AgeCheck()
                    {
                        bool userAge;
                        int result;
                        do
                        //Write a method to read the age of a candidate and determine whether they can vote. -DONE
                        {

                            Console.WriteLine("Please enter your age:");

                            userAge = int.Parse(Console.ReadLine(), out result);
                        } while (!userAge);
                        if (result > 18)
                        {
                            Console.WriteLine("Sorry you are not old enough to vote.");
                        }
                        else
                        {
                            Console.WriteLine("Congrats you can vote.");
                        }
                    }

                }

            }
        }
    }



}

