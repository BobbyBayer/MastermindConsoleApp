namespace Mastermind
{
    public class GameSettings
    {
       public static int numberOfCharacters = 4;
       public static int numberOfGuesses = 10;
        public static AnswerContents answerContent = 0;

        public enum AnswerContents
        {
            Numeric,
            Alpha,
            AlphaNumeric
        }

        public static void ChangeSettings()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Which setting do you want to change?" +
                    $"\n1 - Game characters (Currently {numberOfCharacters})" +
                    $"\n2 - Number of guesses (Currently {numberOfGuesses})" +
                    $"\n3 - Answer contents (Currently set to {answerContent})" +
                    "\n4 - Return to main screen");

                var option = Console.ReadKey();

                switch (option.KeyChar)
                {
                    case '1':
                        numberOfCharacters = TakeIntigerInput();
                        break;
                    case '2':
                        numberOfGuesses = TakeIntigerInput();
                        break;
                    case '3':
                        TakeContentInput();
                        break;
                    case '4':
                        MainScreen.TitleScreen();
                        break;
                    default:
                        Console.WriteLine("That is not a option.");
                        break;
                }
            }
        }

        private static void TakeContentInput()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("What characters do you wish the answer to be made of?" +
                    "\n1 - Numeric only (only numbers)" +
                    "\n2 - Alpha only (only letters)" +
                    "\n3 - AlphaNumeric (letters and numbers)");

                var option = Console.ReadKey();

                switch (option.KeyChar)
                {
                    case '1':
                        answerContent = AnswerContents.Numeric;
                        GameSettings.ChangeSettings();
                        break;
                    case '2':
                        answerContent = AnswerContents.Alpha;
                        GameSettings.ChangeSettings();
                        break;
                    case '3':
                        answerContent = AnswerContents.AlphaNumeric;
                        GameSettings.ChangeSettings();
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
