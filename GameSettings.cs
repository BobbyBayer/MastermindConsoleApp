namespace Mastermind
{
    public class GameSettings
    {
       public static int gameDigits = 4;
       public static int numberOfGuesses = 10;

        public static void ChangeSettings()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Which setting do you want to change?" +
                    $"\n1 - Game digits (Currently {gameDigits})" +
                    $"\n2 - Number of guesses (Currently {numberOfGuesses})" +
                    "\n3 - Return to main screen");

                var option = Console.ReadKey();

                switch (option.KeyChar)
                {
                    case '1':
                        gameDigits = TakeIntigerInput();
                        break;
                    case '2':
                        numberOfGuesses = TakeIntigerInput();
                        break;
                    case '3':
                        MainScreen.TitleScreen();
                        break;
                    default:
                        Console.WriteLine("That is not a option.");
                        break;
                }
            }
        }

        private static int TakeIntigerInput()
        {
            while (true)
            {
                Console.WriteLine("\nInput new intiger then hit enter.");
                var input = Console.ReadLine();

                if (int.TryParse(input, out var val))
                {
                    return val;
                }

                Console.WriteLine("You need to input a intiger.");
            }
        }
    }
}
