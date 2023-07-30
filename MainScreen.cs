using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    public class MainScreen
    {
        public static void TitleScreen()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Hello to Bobby's Mastermind App!" +
                    "\n1 - Play Game" +
                    "\n2 - Settings" +
                    "\n3 - Exit");

                var option = Console.ReadKey();

                switch (option.KeyChar)
                {
                    case '1':
                        Console.Clear();
                        GameInitializer.GiveInstructions();
                        GameProcess.RunGame();
                        break;
                    case '2':
                        GameSettings.ChangeSettings();
                        break;
                    case '3':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("That is not a option.");
                        break;
                }

            }
        }
    }
}
