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
    Console.WriteLine("|-------------------------------------------------------------------------------|");
    Console.WriteLine("|Hello, Can you guess my secret number? You may choose any number between 0-100.|");
    Console.WriteLine("|------------------------Choose your Difficulty---------------------------------|");
    
    // How to get a random number in C#
    // The program picks a number that the challenger must guess..
    Random i = new Random();
    int secretNumber = i.Next(0,100);

    // Users will now have the ability to choose a difficulty level 
    // this will also determine the number of guesses they have
    // instead of losing we can now cheat and guess all the numbers till we get it
    int[] howManyTries = {8, 6, 4, int.MaxValue};
    int choice = difficulty();
    int difficultyLevel = howManyTries[choice -1];

    // Conditional added in order to break an infinite loop until condition is met
    while (true)
    {
        Console.Clear();
        //Console.WriteLine("Hello, Can you guess my secret number?");
        // hold the variable that will determin the number chosen and how many guesses
        int chosen = guess(guesses);

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
            Console.WriteLine("Shoot for the moon! Guess higher...");
            // We will be using the incremented number of guess function to tell them how long
            Console.WriteLine($"You have {difficultyLevel-guesses} more chances");
            // Allow for time to lapse 
            System.Threading.Thread.Sleep(1500);
        }
        else
        {
            guesses++;
            Console.WriteLine("Don't shoow the moon! Guess lower..");
            Console.WriteLine($"You have {difficultyLevel-guesses} more chances...");
            System.Threading.Thread.Sleep(1500);
        }

        // When the user has guessed incorrectly 4 times the program will tell them they have lost.
        if (guesses == difficultyLevel)
        {
            Console.WriteLine($"You have chosen... Poorly! The Meaning of Life is {secretNumber}!");
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
        Console.Write($"You have {tries} tries! Choose your number carefully... ");
        string guess = Console.ReadLine();
        // Let's make a new line
        ;
        // We need to convert the string guessed by user to be converted to int so compare
        // limlit the number of tries to 101 
        if (int.TryParse(guess, out int chosen) && chosen>0 && chosen<101)
        {
            // Return from the line above, convert the string into an integer and given us the value of the variable 'chosen'.
            return chosen;
        }
    }
}

// Now we need to establish the levels and how they interact with the game
int difficulty()
{
    while (true)
    {
        // Display these options to the user and allow them to choose
        Console.Write(@"
                1) Easy (You will be given 8 tries)
                2) Medium (You will be given 6 tries)
                3) Hard (You will only have 4 tries)
                4) Cheater (Cheater, pumpkin eater!!)
                            Level chosen: ");

        string choice = Console.ReadLine();
        // implies a new line should be started after prompt
        ;
        // take the strings from above and convert it to the integer representing that level of difficulty. 
        if (int.TryParse(choice, out int chosenLevel))
        {
            return chosenLevel;
        }
    }
}