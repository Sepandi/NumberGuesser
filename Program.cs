using System;

namespace NumberGueser
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool PlayAgain = true;
            int minNum = 1;
            int maxNum = 10;
            int input;
            int number;
            int countOfguesses;
            string response;
            Console.WriteLine("Guesing Number Game by Sepandi:D");
            Console.WriteLine();
            Console.WriteLine();
            while (PlayAgain == true )
            {
                input = 0;
                countOfguesses = 0;
                number = random.Next(minNum, maxNum+1);
                while(input != number)
                {
                    Console.WriteLine("Guese a Number Between "+ minNum + "-" + maxNum);
                    input = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    if (input > number)
                    {
                        Console.WriteLine(input + " is to High.");
                    }
                    else if (input < number)
                    {
                        Console.WriteLine(input + " is to Low.");
                    }
                    countOfguesses += 1;
                }
                Console.WriteLine("Number was " + number + ". You Got it . Good Job. "+"Your Guese Count : " + countOfguesses);
                Console.Write("Play Again ? (Y/N): ");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    PlayAgain = true;

                }
                else
                {
                    PlayAgain = false;
                }
            }
        }
    }
}
