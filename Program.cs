// Purpose: Write a console program in C# that invites the user to guess a number.

// Phase 1 and 2
// using System;

// Main();

// void Main()
// {
//     Console.WriteLine("Guess the secret number...");
//     AskForNumber("What's your guess? ");
// };

// // Function to ask question
// void AskForNumber(string question)
// {
//     Console.Write($"{question}");
//     string answer = Console.ReadLine();
//     string SecretNumber = "42";

//     if (answer == SecretNumber)
//     {
//         Console.WriteLine("You guessed it!");
//     }
//     else
//     {
//         Console.WriteLine($"{answer}? That's not quite right.");
//     }

// };


// Phase 3
using System;

Main();

void Main()
{
    // Change colors
    Console.Title = "Guessing Game";
    Console.ForegroundColor = ConsoleColor.Green;

    // Say something to user, and ask a question
    Console.WriteLine("Guess the secret number...");
    AskForNumber("What's your guess? ");
};


// Function to ask question
void AskForNumber(string question)
{
    // Generate a random number
    Random Number = new Random();
    int SecretNumber = Number.Next(1, 100);

    // int SecretNumber = 42;
    int GuessLimit = 4;
    int GuessCount = 1;

    while (GuessLimit > 0)
    {

        Console.Write($"{question}");
        int Answer = Convert.ToInt32(Console.ReadLine());

        if (Answer != SecretNumber)
        {
            GuessLimit--;
            Console.WriteLine($"You got: {GuessLimit} guesses left. Be smart about it!");
            GuessCount++;

        }
        else if (Answer == SecretNumber)
        {
            Console.WriteLine($"You guessed it! Only took 'bout {GuessCount} times.");
            return;
        }
    }

};

