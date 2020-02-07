using System;

namespace Var
{
    class Program
    {

        static void GameOn()
        {
            int score = 0;
            int error = 0;
            int sum = 0;
            var rand = new Random();
Game:
            int num1 = rand.Next(10);
            int num2 = rand.Next(10);
            int operation = rand.Next(3);
Answer:
            if (operation == 0)
            {
                sum = num1 * num2;
                Console.WriteLine($"What is {num1} * {num2} ?");
            }
            else if (operation == 1)
            {
                sum = num1 - num2;
                Console.WriteLine($"What is {num1} - {num2} ?");
            }
            else if (operation == 2)
            {
                sum = num1 + num2;
                Console.WriteLine($"What is {num1} + {num2} ?");
            } 
            else if (operation == 3)
            {
                sum = num1 / (num2 + 1);
                Console.WriteLine($"What is {num1} / {num2 + 1} ?");
            }
            string answer = Console.ReadLine();

            if (answer == $"{sum}")
            {
                score++;
                goto Game;
            } else if (answer == "end")
            {
                Console.WriteLine("You got a score of " + score);
                Console.WriteLine("Errors made " + error);
            }
            else
            {
                Console.WriteLine("incorrect");
                error++;
                goto Answer;
            }
        }
        static void Main()
        {
            string greeting = "Hello, great and powerful user! The games condition is: ";
            bool gameStarted = false;
            string displayGameState = greeting + gameStarted;
            string quiry = "initiate game? y/n";
            string command = "you found me";
            string error = "error: valid inputs are y or n";

            Console.WriteLine(displayGameState);
quiry:
            Console.WriteLine(quiry);
            command = Console.ReadLine();

            if (command == "y")
            {
                gameStarted = true;
            }
            else if (command == "n")
            {
                gameStarted = false;
            }
            else
            {
                Console.WriteLine(error);
                goto quiry;
            }
            if (gameStarted == true)
            {
                Console.WriteLine("Game On!");
                Console.WriteLine("type 'end' to stop playing");
                GameOn();
            }
            else
            {
                Console.Clear();
            }
        }
    }
}
