using System;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {

            //    int guessCounter = 0;
            //     while (guessCounter >= 4) 

            int secretNum = new Random().Next(1, 101);

            Console.WriteLine("ARE YOU FEELING LUCKY PUNK?");
            // Console.WriteLine("guess the secret number.");
            // Console.Write("input your guess here: ");
            Console.WriteLine("Pick Your difficulty level: easy, medium or hard");
            string difficultyLevel = Console.ReadLine().ToLower();
            Console.WriteLine($"{difficultyLevel} huh? we will see about that");
            if (difficultyLevel == "easy")
            {
                for (int i = 0; i < 8; i++)
                {
                    string guess = Console.ReadLine();
                    int IntegerGuess = int.Parse(guess);
                    Console.Write("your guess needs to be a little");
                    
                    if (IntegerGuess < secretNum)
                    {
                        Console.WriteLine(" higher");
                    }
                    else if (IntegerGuess > secretNum)
                    {
                        Console.WriteLine(" lower");
                    }
                    else
                    {
                        Console.WriteLine(" you did it");
                        break;
                    }
                }
            }
             if (difficultyLevel == "medium")
            {
                for (int i = 0; i < 6; i++)
                {
                    string guess = Console.ReadLine();
                    int IntegerGuess = int.Parse(guess);
                    Console.Write("your guess needs to be a little");
                    Console.WriteLine(guess);
                    if (IntegerGuess < secretNum)
                    {
                        Console.WriteLine(" higher");
                    }
                    else if (IntegerGuess > secretNum)
                    {
                        Console.WriteLine(" lower");
                    }
                    else
                    {
                        Console.WriteLine(" you did it");
                        break;
                    }
                }
            }
            if (difficultyLevel == "hard")
            {
                for (int i = 0; i < 4; i++)
                {
                    string guess = Console.ReadLine();
                    int IntegerGuess = int.Parse(guess);
                    Console.Write("your guess needs to be a little");
                    Console.WriteLine(guess);
                    if (IntegerGuess < secretNum)
                    {
                        Console.WriteLine(" higher");
                    }
                    else if (IntegerGuess > secretNum)
                    {
                        Console.WriteLine(" lower");
                    }
                    else
                    {
                        Console.WriteLine(" you did it");
                        break;
                    }
                }
            }
            if (difficultyLevel == "cheater")
            {
                for (int i = 0; i < 101; i++)
                {
                    string guess = Console.ReadLine();
                    int IntegerGuess = int.Parse(guess);
                    Console.Write("your guess needs to be a little");
                    Console.WriteLine(guess);
                    if (IntegerGuess < secretNum)
                    {
                        Console.WriteLine(" higher");
                    }
                    else if (IntegerGuess > secretNum)
                    {
                        Console.WriteLine(" lower");
                    }
                    else
                    {
                        Console.WriteLine(" you did it");
                        break;
                    }
                }
            }












        }
    }
}





// while (guess.Length == 0)
//                 {
//                     Console.WriteLine("guess the secret number.");
//                     guess = Console.ReadLine();
//                 }
//                 if (IntegerGuess == secretNum)
//                 {
//                     Console.WriteLine("you fucking got it you dirty dog");
//                 }
//                 else
//                 {
//                     Console.WriteLine(" man you are bad at this");
//                 }






















// bool isNum = int.TryParse(guess, out int n);

// Console.WriteLine($"input = {guess}");

// while (isNum == false)
// {
//     Console.WriteLine("Please enter a digit!");                
//     guess = Console.ReadLine();
// }   






// while (isNum == false)
// {
//     Console.WriteLine("Please enter a digit!");                
//     guess = Console.ReadLine();
// }    


// int finalGuess = new int(); 