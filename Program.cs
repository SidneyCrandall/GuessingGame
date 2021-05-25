using System;

Main();

void Main()
{
    // Set up for the program
    Console.WriteLine("Hello, Can you guess my secret number?");
    // users will be to pick a number
    Console.Write("What number do you choose? ");

    // declaring th type 
    string guess = Console.ReadLine();

    // Hard coded chosen number for users to guess
    int secretnumber = 42;

    // We need to convert the string guessed by user to be converted to int so compare 
    // We also need to see if the user is correct or wrong depending on the number. 
    // We also return a string of congrats or try agin.
    if (int.TryParse(guess, out int chosen))
    {
        if (chosen == secretnumber)
        {
            Console.Write("You have chosen... Wisely!");
        }
        else
        {
            Console.WriteLine("You chose... poorly");
        }
    }
}




