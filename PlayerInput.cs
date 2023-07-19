namespace Mastermind;

internal class PlayerInput
{
    public static int[] GetGuess(int gameDigits)
    {
        var guess = new int[gameDigits];

        for (var i = 0; i < gameDigits; i++)
        {
            if (int.TryParse(Console.ReadKey().KeyChar.ToString(), out var result))
            {
                guess[i] = result;
            }
            else
            {
                Console.WriteLine("\nYou can only enter numeric digits.\n" +
                                  "Enter a new guess.");

                guess = new int[gameDigits];
                i = -1;
            }
        }

        return guess;
    }

    public static void EndGame()
    {
        Console.WriteLine("\n\nPress any key to exit.");
        Console.ReadKey();
    }
}