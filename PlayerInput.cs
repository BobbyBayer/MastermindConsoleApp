namespace Mastermind;

internal class PlayerInput
{
    public static char[] GetGuess(int gameCharactersCount)
    {
        var guess = new char[gameCharactersCount];

        for (var i = 0; i < gameCharactersCount; i++)
        {
            var readKey = Console.ReadKey().KeyChar;
            if (readKey.ToString().All(char.IsLetterOrDigit))
            {
                guess[i] = char.ToLower(readKey);
            }
            else
            {
                Console.WriteLine($"\nYou can only enter {GameSettings.answerContent} characters.\n" +
                                  "Enter a new guess.");

                guess = new char[gameCharactersCount];
                i = -1;
            }
        }

        return guess;
    }
}