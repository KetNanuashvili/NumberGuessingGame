


//int randomNumber;

//do
//{
//    randomNumber = random.Next(min, max + 1);
//} while (randomNumber % 10 == 0);

//Console.WriteLine($"Your random number is: {randomNumber}");
//while (true)
//{
//    Console.WriteLine("You have 5 try");

//    Console.WriteLine("Enter Your guess Number");
//    string input = Console.ReadLine();
//    int guessNumber;

//    if (int.TryParse(input, out guessNumber))
//    {
//        if (guessNumber == randomNumber)
//        {
//            Console.WriteLine("You Win");
//        }
//        else if (guessNumber >= randomNumber)
//        {
//            Console.WriteLine("your enter Number is" + guessNumber + "and its higher than randomnumber ");
//        }
//        else if (guessNumber <= randomNumber)
//        {
//            Console.WriteLine("your enter Number is" + guessNumber +  "and its lower than randomnumber ");
//        }
//    }
//    else
//    {
//        Console.WriteLine("Invalid input! Please enter a valid number.");
////    }
//int chooseLevel()
//{
//    Console.WriteLine("Choose difficulty level: Easy, Medium, Hard");

//    string? difficulty = Console.ReadLine()?.ToLower();

//    int min = 0, max = 0;

//    switch (difficulty)
//    {
//        case "easy":
//            max = 50;
//            Console.WriteLine("You selected Easy level. Max value is 50.");
//            break;
//        case "medium":
//            max = 100;
//            Console.WriteLine("You selected Medium level. Max value is 100.");
//            break;
//        case "hard":
//            max = 200;
//            Console.WriteLine("You selected Hard level. Max value is 200.");
//            break;
//        default:
//            Console.WriteLine("Invalid difficulty level. Defaulting to Easy.");
//            max = 50;
//            break;
//    }

//    Random random = new Random();
//    int randomNumber = random.Next(min, max + 1);  // Generate random number in the range [min, max]

//    return randomNumber;  // Return the random number
//}


//void playGame()
//{
//    int randomNumber;
//    do
//    {
//        randomNumber = chooseLevel(); 
//    } while (randomNumber % 10 == 0); 

//    Console.WriteLine("I have selected a random number. Try to guess it!");

//    int maxTry = 5;
//    List<int> guesses = new List<int>();

//    for (int tries = 1; tries <= maxTry; tries++)
//    {
//        Console.WriteLine($"Attempt {tries}/{maxTry}: Enter your guess:");
//        string input = Console.ReadLine();
//        int guessNumber;

//        if (int.TryParse(input, out guessNumber))
//        {
//            guesses.Add(guessNumber);

//            if (guessNumber == randomNumber)
//            {
//                Console.WriteLine("Congratulations! You guessed the correct number!");
//                break;
//            }
//            else if (guessNumber > randomNumber)
//            {
//                Console.WriteLine($"Your guess {guessNumber} is too high.");
//            }
//            else
//            {
//                Console.WriteLine($"Your guess {guessNumber} is too low.");
//            }

//            Console.WriteLine("Your previous guesses: [" + string.Join(", ", guesses) + "]");

//            if (tries == maxTry)
//            {
//                Console.WriteLine($"You've run out of attempts. The correct number was {randomNumber}.");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Invalid input! Please enter a valid number.");
//        }
//    }
//}





//while (true)
//{
//    Console.WriteLine("Do you want to play again? (yes/no)");
//    string playAgain = Console.ReadLine()?.Trim().ToLower();

//    if (playAgain == "yes")
//    {
//        Console.WriteLine("Great! Let's play again.");
//        playGame();
//    }
//    else if (playAgain == "no")
//    {
//        Console.WriteLine("Thanks for playing! Goodbye.");
//        break; // ციკლის შეწყვეტა
//    }
//    else
//    {
//        Console.WriteLine("Invalid input. Please type 'yes' or 'no'.");
//    }
int chooseLevel()
{
    Console.WriteLine("Choose difficulty level: Easy, Medium, Hard");

    string? difficulty = Console.ReadLine()?.ToLower();

    int min = 0;
    int max;

    switch (difficulty)
    {
        case "easy":
            max = 50;
            Console.WriteLine("You selected Easy level. Max value is 50.");
            break;
        case "medium":
            max = 100;
            Console.WriteLine("You selected Medium level. Max value is 100.");
            break;
        case "hard":
            max = 200;
            Console.WriteLine("You selected Hard level. Max value is 200.");
            break;
        default:
            Console.WriteLine("Invalid difficulty level. Defaulting to Easy.");
            max = 50;
            break;
    }

    return max;
}

void playGame()
{
    int maxValue = chooseLevel();

    Random random = new Random();
    int randomNumber;

    do
    {
        //რენდომ რიცხვის გენერირიება
        randomNumber = random.Next(0, maxValue + 1);
    } while (randomNumber % 10 == 0);

    Console.WriteLine("I have selected a random number. Try to guess it!");

    int maxTry = 5;
    //გენერიკული კოლექცია, რომელიც ინახავს int ტიპის ელემენტებს. 
    List<int> guesses = new List<int>();

    for (int tries = 1; tries <= maxTry; tries++)
    {
        Console.WriteLine($"Attempt {tries}/{maxTry}: Enter your guess:");
        string input = Console.ReadLine();
        int guessNumber;

        if (int.TryParse(input, out guessNumber))
        {
            guesses.Add(guessNumber);

            if (guessNumber == randomNumber)
            {
                Console.WriteLine("Congratulations! You guessed the correct number!");
                break;
            }
            else if (guessNumber > randomNumber)
            {
                Console.WriteLine($"Your guess {guessNumber} is too high.");
            }
            else
            {
                Console.WriteLine($"Your guess {guessNumber} is too low.");
            }
            //შეყვანილი რიცხვების დაკავშირება და ყველა შეყვანილი რიცხვის დაკავშირება
            Console.WriteLine("Your previous guesses: [" + string.Join(", ", guesses) + "]");

            if (tries == maxTry)
            {
                Console.WriteLine($"You've run out of attempts. The correct number was {randomNumber}.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a valid number.");
        }
    }
}

while (true)
{
    playGame();

    Console.WriteLine("Do you want to play again? (yes/no)");
    string playAgain = Console.ReadLine()?.Trim().ToLower();

    if (playAgain == "yes")
    {
        Console.WriteLine("Great! Let's play again.");
    }
    else if (playAgain == "no")
    {
        Console.WriteLine("Thanks for playing! Goodbye.");
        break;
    }
    else
    {
        Console.WriteLine("Invalid input. Please type 'yes' or 'no'.");
    }
}
