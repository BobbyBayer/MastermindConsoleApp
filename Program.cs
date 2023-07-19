using Mastermind;

Console.WriteLine("Hello to Bobby's Mastermind App!");

const int gameDigits = 4;
const int numberOfGuesses = 10;

GameInitializer.GiveInstructions(gameDigits, numberOfGuesses);

var answer = GameInitializer.GenerateAnswer(gameDigits);

GameProcess.RunGame(gameDigits, numberOfGuesses, answer);