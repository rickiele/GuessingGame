// Purpose: Write a console program in C# that invites the user to guess a number.

using System;
using System.Collections.Generic;
using System.Linq;

Main();

void Main()
{
    // Change colors
    Console.Title = "Guessing Game";
    Console.ForegroundColor = ConsoleColor.Green;

    // Say something to user, and ask a question
    Console.WriteLine("Welcome to the Guessing Game!");
    AskForDifficulty("What difficulty do you want to play on?\n[1] Easy\n[2] Medium\n[3] Hard\n[4] Cheater!!!\nEnter difficulty level: ");
};

// Function to determine difficulty chosen
void AskForDifficulty(string DifficultyQuestion)
{
    Console.Write($"{DifficultyQuestion}");
    int ChosenLevel = Convert.ToInt32(Console.ReadLine());

    if (ChosenLevel == 1)
    {
        AskForNumber(8);
    }
    else if (ChosenLevel == 2)
    {
        AskForNumber(6);
    }
    else if (ChosenLevel == 3)
    {
        AskForNumber(4);
    }
    else if (ChosenLevel == 4)
    {
        // Largest possible value of Int32
        AskForNumber(Int32.MaxValue);
    };
}


// Function to ask for number
void AskForNumber(int GuessLimit)
{
    // Generate a random number
    Random Number = new Random();
    int SecretNumber = Number.Next(1, 100);

    int GuessCount = 1;

    while (GuessLimit > 0)
    {

        Console.Write("Be smart about it and guess the number! ");
        int Answer = Convert.ToInt32(Console.ReadLine());

        if (Answer != SecretNumber)
        {
            if (Answer > SecretNumber)
            {
                GuessLimit--;
                Console.WriteLine($"You got: {GuessLimit} guesses left, and your answer is too high.\n");
                GuessCount++;
            }
            else if (Answer < SecretNumber)
            {
                GuessLimit--;
                Console.WriteLine($"You got: {GuessLimit} guesses left, and your answer is too low.\n");
                GuessCount++;
            }

        }
        else if (Answer == SecretNumber)
        {
            Console.WriteLine($"You guessed it! Only took 'bout {GuessCount} times.");
            return;
        }
    }

};

