﻿namespace Mastermind;

internal class GameProcess
{
    public static void RunGame()
    {
        var numberOfCharacters = GameSettings.numberOfCharacters;
        var numberOfGuesses = GameSettings.numberOfGuesses;
        var answer = GameInitializer.GenerateAnswer();
        Console.WriteLine("\n" + string.Join(' ', answer));

        Console.WriteLine("\nTake your first guess!");

        var stopGame = false;
        while (stopGame.Equals(false))
        {
            var guess = PlayerInput.GetGuess(numberOfCharacters);
            numberOfGuesses--;

            var result = "";
            for (var i = 0; i < numberOfCharacters; i++)
            {
                if (guess[i].Equals(answer[i]))
                {
                    result += "+";
                }
                else if (answer.Any(a => guess[i].Equals(a)))
                {
                    result += "-";
                }
                else
                {
                    result += " ";
                }
            }

            if (result.Equals(new string('+', numberOfCharacters)))
            {
                Console.WriteLine("\n\nYou have won the game!!!");
                stopGame = true;
            }
            else if (numberOfGuesses.Equals(0))
            {
                Console.WriteLine("\n" + result);
                Console.WriteLine("\nYou have lost the game. I am sorry.");
                Console.WriteLine("The answer was " + string.Join(' ', answer));
                stopGame = true;
            }
            else
            {
                Console.WriteLine("\n" + result);
                Console.WriteLine("You have " + numberOfGuesses + " guesses left.");
            }
        }

        Console.WriteLine("\nPress any key to go to main menu.");
        Console.ReadKey();
        MainScreen.TitleScreen();
    }
}