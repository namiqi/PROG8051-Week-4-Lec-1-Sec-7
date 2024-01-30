using System;


namespace CSharpTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            // break and continue



            // Guessing game

            Random r = new Random();
            int guessnum = r.Next(0, 100);
            int countguess = 0;
            bool result = true;

            while (result)
            {
                Console.WriteLine("Enter Input");
                int myguess = Convert.ToInt32(Console.ReadLine());

             /*   if (countguess > 5)
                {
                    break;
                }*/
                

                if (myguess == guessnum)
                {
                    continue;
                    result = false;
                }
                else if(myguess < guessnum)
                {
                    Console.WriteLine("go up");
                }
                else if (myguess > guessnum)
                {
                    Console.WriteLine("go down");
                }
                countguess++;
            }

            Console.WriteLine(countguess);


            // While Loop

            int start = 1;

            int countevent = 0;

            while (start <= 50) {
                
                if (start % 2 == 0)
                {
                    countevent++;
                }
                start++;
            }
            Console.WriteLine(countevent);



            
            
            
            
            
            // //////////




            int evenNumbers = 0;
            int sumOfEvenNumbers = 0;

            Console.WriteLine("Even Numbers!");

            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {

                    evenNumbers++;
                    sumOfEvenNumbers = i + sumOfEvenNumbers;
                }

            }
            Console.WriteLine("Count of Even Numbers are between 1 to 50 are : " + evenNumbers);
            Console.WriteLine("Sum of Even Numbers Between 1 to 50 are : " + sumOfEvenNumbers);


        

        // Exercise: Rock Paper Scissors

        // Exercise 
        // 1.1 count the number even numbers between 1 and 50 
        // 1.2 find the sum of all the even numbers between 1 and 50

        int countEvenNums = 0;
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    countEvenNums++;
                }
            }
            
            Console.WriteLine(countEvenNums);
            int countOfEvenNumsBetween = CountEvenNumbersBetween(1, 50);
            Console.WriteLine($"Count of even nums between 1 and 50: {countOfEvenNumsBetween}");

            int sumOfEvens = SumOfEvenNumbersBetween(1, 50);
            Console.WriteLine($"Sum of even nums between 1 and 50: {sumOfEvens}");

            static int CountEvenNumbersBetween(int initValue, int finalValue)
            {
                int countEvenNums = 0;
                for (int i = initValue; i <= finalValue; i++)
                {
                    if (i % 2 == 0)
                    {
                        countEvenNums++;
                    }
                }
                return countEvenNums;
            }

            static int SumOfEvenNumbersBetween(int initValue, int finalValue)
            {
                int sumOfEvenNums = 0;
                for (int i = initValue; i <= finalValue; i++)
                {
                    if (i % 2 == 0)
                    {
                        sumOfEvenNums += i;
                    }
                }
                return sumOfEvenNums;
            }


            // Totalling
            int p1points = 0;
            int p2points = 0;


            // Counting
            int p1wincount = 0;
            int p2wincount = 0;
            int draws = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Player 1: ");
                string p1 = Console.ReadLine();

                Console.WriteLine("Player 2: ");
                string p2 = Console.ReadLine();

                if (p1 == p2)
                {
                    Console.WriteLine("draw");
                    draws++;

                }

                else if ((p1 == "R" && p2 == "S") || (p1 == "P" && p2 == "R") || (p1 == "S" && p2 == "P"))
                {
                    Console.WriteLine("P1 wins");
                    p1wincount++;
                    p1points = p1points + 5;

                }

                else if ((p1 == "R" && p2 == "P") || (p1 == "P" && p2 == "S") || (p1 == "S" && p2 == "R"))
                {
                    Console.WriteLine("P2 wins");
                    p2wincount++;
                    p2points = p2points + 5;
                }

                else
                {
                    Console.WriteLine("Bad input");
                }

            }
            Console.WriteLine($"As a result, player 1 won {p1wincount} times, player2 won {p2wincount} times and there were {draws} draws");
            Console.WriteLine($"playe1 has {p1points} points and player2 has {p2points}");
            
            // Exercise :calculator
            Console.WriteLine("This is before the loop ");

            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine("Please enter 1st num: ");

                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter 2nd num: ");

                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter operation: ");

                string op = Console.ReadLine();

                if (op == "+")
                {
                    Console.WriteLine(num1 + num2);
                }

                else if (op == "-")
                {
                    Console.WriteLine(num1 - num2);
                }

                else if (op == "/")
                {
                    Console.WriteLine(num1 / num2);
                }

                else if (op == "*")
                {
                    Console.WriteLine(num1 * num2);
                }

                else
                {
                    Console.WriteLine("");
                }

            }

            Console.WriteLine("After the loop ");

            // Loops

            // For Loop

            for (int i = 1; i <= 4; i = i + 2)
            {
                Console.WriteLine(i);
            }





            
        }
    }
}