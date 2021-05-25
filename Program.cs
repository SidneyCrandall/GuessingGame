using System;

// clears the console and moves the cursor to the top left of the console
Console.Clear();

// used to control the whole of the code
Main();

// Won't return anything till told to
void Main()
{

    // Establishing the number of tries a user has and incrementing later in the code
    int guesses = 0;

    // Conditional added in order to break an infinite loop until condition is met
    while (true)
    {

        // Set up for the program
        Console.WriteLine("Hello, Can you guess my secret number?");

        // hold the variable that will determin the number chosen and how many guesses
        int chosen = guess();

        // Hard coded chosen number for users to guess
        int secretNumber = 42;

        // We also need to see if the user is correct or wrong depending on the number. 
        // We also return a string of congrats or try agin.
        if (chosen == secretNumber)
        {
            Console.Write("You have chosen... Wisely!");
            return;
        }

        // if they havent chosen correctly at first then give them a new chance to guess
        else
        {
            Console.WriteLine("You chose... poorly. Try again!");
            // Increemnet the number of times a user has guessed till the condition is met (+1)
            guesses++;
        }

        // When the user has guessed incorrectly 4 times the program will tell them they have lost.
        if (guesses == 4)
        {
            Console.WriteLine("You have failed...");
            return;
        }
    }
}

// Here we figure out how tally the number of guesses and prompt them to guess agin
int guess()
{
    while (true)
    {
        // users will be to pick a number
        Console.Write("What number do you choose? ");
        string guess = Console.ReadLine();
        ;
        // We need to convert the string guessed by user to be converted to int so compare 
        if (int.TryParse(guess, out int chosen))
        {
            // Return from the line above, convert the string into an integer and given us the value of the variable 'chosen'.
            return chosen;
        }
    }
}



