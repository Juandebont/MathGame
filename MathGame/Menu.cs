using ConsoleTables;

namespace MathGame
{
    internal class Menu
    {
        GameEngine gameEngine = new GameEngine();
        ConsoleTable table = new ConsoleTable("What game mode would you like to play?", "");

        public void CreateMenu()
        {
            table.AddRow("- A", "Addition")
                 .AddRow("- S", "Subtraction")
                 .AddRow("- M", "Multiplication")
                 .AddRow("- D", "Division")
                 .AddRow("- R", "Random")
                 .AddRow("- Q", "Quit the program");
        }

        public void ChooseGame()
        {
            table.Write(Format.Minimal);

            Console.Write("Enter your input here: ");
            string userInput = Console.ReadLine();

            switch (userInput.Trim().ToLower())
            {
                case "a":
                    gameEngine.AdditionGame(true);
                    break;
                case "s":
                    gameEngine.SubtractionGame(true);
                    break;
                case "m":
                    gameEngine.MultiplicationGame(true);
                    break;
                case "d":
                    gameEngine.DivisionGame(true);
                    break;
                case "r":
                    gameEngine.RandomGame(true);
                    break;
                case "q":
                    Console.Clear();
                    Console.WriteLine("Thank you for playing MathGame");
                    System.Threading.Thread.Sleep(2000);
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
