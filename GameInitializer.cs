﻿namespace Mastermind;

public class GameInitializer
{
    public static void GiveInstructions()
    {
        Console.WriteLine("Instructions:\n" +
                          $"The object of the game is the guess the {GameSettings.gameDigits} digit answer.\n" +
                          "The answer digits are between 1-6.\n" +
                          $"You will have {GameSettings.numberOfGuesses} guesses to get it correct.\n" +
                          "If you guess the position and digit correct a + will be returned.\n" +
                          "If you guess the digit correct but in the wrong position a - will be returned.\n" +
                          "A blank space will be returned for incorrect guesses.");
    }

    public static int[] GenerateAnswer()
    {
        var gameDigits = GameSettings.gameDigits;

        var rnd = new Random();

        var answer = new int[gameDigits];

        for (var i = 0; i < gameDigits; i++)
        {
            answer[i] = rnd.Next(1, 6);
        }

        return answer;
    }
}