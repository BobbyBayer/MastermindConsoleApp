namespace Mastermind;

public class GameInitializer
{
    public static void GiveInstructions()
    {
        var contents = GetContentDescriptioin();
        Console.WriteLine("Instructions:\n" +
                          $"The object of the game is the guess the {GameSettings.numberOfCharacters} character answer.\n" +
                          $"The answer characters will be between {contents}. (Case sensitivity does not matter.)\n" +
                          $"You will have {GameSettings.numberOfGuesses} guesses to get it correct.\n" +
                          "If you guess the position and caracter correct a + will be returned.\n" +
                          "If you guess the character correct but in the wrong position a - will be returned.\n" +
                          "A blank space will be returned for incorrect guesses.");
    }

    private static string GetContentDescriptioin()
    {
        return (int)GameSettings.answerContent switch
        {
            0 => "0-9", //Numeric
            1 => "a-z", //Alpha
            2 => "0-9 and/or a-z", //AlphaNmeric
            _ => "",
        };
    }

    public static char[] GenerateAnswer()
    {
        var gameCharactersCount = GameSettings.numberOfCharacters;

        var answer = new char[gameCharactersCount];

        for (var i = 0; i < gameCharactersCount; i++)
        {
            answer[i] = GetRandomGeneration();
        }

        return answer;
    }

    private static char GetRandomGeneration()
    {
        var alpha = "abcdefghijklmnopqrstuvwxyz";
        var numeric = "0123456789";
        var alphanumeric = alpha + numeric;

        var rnd = new Random();

        if (GameSettings.answerContent.Equals(GameSettings.AnswerContents.Numeric))
        {
            return numeric[rnd.Next(numeric.Length)];
        }
        else if (GameSettings.answerContent.Equals(GameSettings.AnswerContents.Alpha))
        {
            return alpha[rnd.Next(alpha.Length)];
        }
        else
        {
            return alphanumeric[rnd.Next(alphanumeric.Length)];
        }
    }
}