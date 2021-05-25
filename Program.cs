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

    // Prompt the user to choose a number between 1-100.
    Console.WriteLine("Hello, Can you guess my secret number? Choose a number between 0-100.");
    
    // How to get a random number in C#
    Random i = new Random();
    int secretNumber = i.Next(0,100);

    // Conditional added in order to break an infinite loop until condition is met
    while (true)
    {
        Console.Clear();
        Console.WriteLine("Hello, Can you guess my secret number?");
        // hold the variable that will determin the number chosen and how many guesses
        int chosen = guess(guesses);

        // Hard coded chosen number for users to guess
        //int secretNumber = 42;

        // We also need to see if the user is correct or wrong depending on the number. 
        // We also return a string of congrats or try agin.
        if (chosen == secretNumber)
        {
            Console.Write("You have chosen... Wisely!");
            return;
        }

        // if/else they havent chosen correctly after the first try then give them a new chance to guess and let them knwo how many more they have
        else if (chosen < secretNumber)
        {
            // Increemnet the number of times a user has guessed till the condition is met (+1)
            guesses++;
            Console.WriteLine("Shoot for the moon, guess higher...");
            // We will be using the incremented number of guess function to tell them how long
            Console.WriteLine($"You have {4-guesses} more chances");
            // Allow for time to lapse 
            System.Threading.Thread.Sleep(3000);
        }
        else
        {
            guesses++;
            Console.WriteLine("Shoot for the moon, guess higher..");
            Console.WriteLine($"You have {4-guesses} more chances...");
            System.Threading.Thread.Sleep(3000);
        }

        // When the user has guessed incorrectly 4 times the program will tell them they have lost.
        if (guesses == 4)
        {
            Console.WriteLine("You have failed...");
            Console.WriteLine($"The correct number was {secretNumber}!");
            return;
        }
    }
}

// Here we figure out how tally the number of guesses and prompt them to guess agin
int guess(int tries)
{
    while (true)
    {
        // users will be to pick a number
        Console.Write($"What number do you choose? ({tries}) ");
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