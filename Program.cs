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
    Console.WriteLine("Guess the secret number...");
    AskForNumber("What's your guess? ");
};

// Function to ask question
void AskForNumber(string question)
{
    Console.Write($"{question}");
    string answer = Console.ReadLine();
    string SecretNumber = "42";

    int num = 1;

    while (num < 4)
        if (answer == SecretNumber)
        {
            Console.WriteLine("You guessed it!");
        }
        else
        {
            Console.WriteLine($"That's not quite right. Try again");
        }
    num++;

};
