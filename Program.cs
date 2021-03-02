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
// using System;

// Main();

// void Main()
// {
//     // Change colors
//     Console.Title = "Guessing Game";
//     Console.ForegroundColor = ConsoleColor.Green;

//     // Say something to user, and ask a question
//     Console.WriteLine("Guess the secret number...");
//     AskForNumber("What's your guess? ");
// };

// // Function to ask question
// void AskForNumber(string question)
// {
//     Console.Write($"{question}");
//     int Answer = Convert.ToInt32(Console.ReadLine());
//     int SecretNumber = 42;

//     if (Answer == SecretNumber)
//     {
//         Console.WriteLine("You guessed it!");
//     }
//     else
//     {
//         for (int count = 0; count < 4; count++)
//         {
//             if (Answer != SecretNumber)
//             {
//                 Console.WriteLine($"That's not quite right. Try again");
//                 Console.Write($"{question}");
//                 Console.ReadLine();
//             }
//             else if (Answer == SecretNumber)
//             {
//                 Console.WriteLine($"What the");

//             }

//         }
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
    Console.Write($"{question}");
    int Answer = Convert.ToInt32(Console.ReadLine());
    int SecretNumber = 42;

    if (Answer == SecretNumber)
    {
        Console.WriteLine("You guessed it!");
    }
    else
    {
        for (int GuessCount = 0; GuessCount < 4; GuessCount++)
        {
            Console.WriteLine($"That's not quite right. Try again");
            Console.ReadLine();
        }
    }
};
