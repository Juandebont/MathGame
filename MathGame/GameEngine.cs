namespace MathGame
{
    internal class GameEngine
    {      
        Helpers helper = new Helpers();
        bool randomGame = false;
        public void AdditionGame(bool play)
        {
            Console.Clear();
            int randomNumber1 = helper.GetRandomNumber(1, 100);
            int randomNumber2 = helper.GetRandomNumber(1, 100);
            int result = randomNumber1 + randomNumber2;    
            
            while (play == true)
            {
                Console.WriteLine($"{randomNumber1} + {randomNumber2}");
                Console.Write("Enter your answer here: ");
                string userInput = Console.ReadLine();
                if (Int32.TryParse(userInput, out int number) && number == result)
                {
                    Console.WriteLine($"Correct!, the answer was {result}");
                    Console.Write($"Want to play again? Y/N ");
                    string userInput2 = Console.ReadLine();
                    if (userInput2.Trim().ToLower() == "y" && randomGame == false)
                    {
                        AdditionGame(true);
                    }
                    else if (userInput2.Trim().ToLower() == "y" && randomGame == true)
                    {
                        RandomGame(true);
                    }
                    else if (userInput2.Trim().ToLower() == "n")
                    {
                        play = false;
                    } else
                    {
                        Console.WriteLine($"Type \"Y\" or \"N\"");
                    }
                }
                else
                {
                    Console.WriteLine($"Not correct! Try again");
                }
                break;
            }
            
        }
        public void SubtractionGame(bool play)
        {
            Console.Clear();
            int randomNumber1 = helper.GetRandomNumber(100, 200);
            int randomNumber2 = helper.GetRandomNumber(1, 100);
            int result = randomNumber1 - randomNumber2;
            while (play)
            {
                Console.WriteLine($"{randomNumber1} - {randomNumber2}");
                Console.Write("Enter your answer here: ");
                string userInput = Console.ReadLine();
                if (Int32.TryParse(userInput, out int number) && number == result)
                {
                    Console.WriteLine($"Correct!, the answer was {result}");
                    Console.Write($"Want to play again? Y/N ");
                    string userInput2 = Console.ReadLine();
                    if (userInput2.Trim().ToLower() == "y" && randomGame == false)
                    {
                        SubtractionGame(true);
                    }
                    else if (userInput2.Trim().ToLower() == "y" && randomGame == true)
                    {
                        RandomGame(true);
                    }
                    else if (userInput2.Trim().ToLower() == "n")
                    {
                        play = false;
                    }
                    else
                    {
                        Console.WriteLine($"Type \"Y\" or \"N\"");
                    }
                }
                else
                {
                    Console.WriteLine($"Not correct! Try again");
                }
                break;
            }
        }
        public void MultiplicationGame(bool play)
        {
            Console.Clear();
            int randomNumber1 = helper.GetRandomNumber(1, 10);
            int randomNumber2 = helper.GetRandomNumber(1, 10);
            int result = randomNumber1 * randomNumber2;
            while (play)
            {
                Console.WriteLine($"{randomNumber1} * {randomNumber2}");
                Console.Write("Enter your answer here: ");
                string userInput = Console.ReadLine();
                if (Int32.TryParse(userInput, out int number) && number == result)
                {
                    Console.WriteLine($"Correct!, the answer was {result}");
                    Console.Write($"Want to play again? Y/N ");
                    string userInput2 = Console.ReadLine();
                    if (userInput2.Trim().ToLower() == "y" && randomGame == false)
                    {
                        MultiplicationGame(true);
                    }
                    else if (userInput2.Trim().ToLower() == "y" && randomGame == true)
                    {
                        RandomGame(true);
                    }
                    else if (userInput2.Trim().ToLower() == "n")
                    {
                        play = false;
                    }
                    else
                    {
                        Console.WriteLine($"Type \"Y\" or \"N\"");
                    }
                }
                else
                {
                    Console.WriteLine($"Not correct! Try again");
                }
                break;
            }
        }
        public void DivisionGame(bool play)
        {
            Console.Clear();
            int randomNumber1 = helper.GetRandomNumber(10, 1000);
            int randomNumber2 = helper.GetRandomNumber(1, 10);
            int result = randomNumber1 / randomNumber2;
            while (play)
            {
                Console.WriteLine($"{randomNumber1} / {randomNumber2}");
                Console.Write("Enter your answer here: ");
                string userInput = Console.ReadLine();
                if (Int32.Parse(userInput) == result)
                {
                    Console.WriteLine($"Correct!, the answer was {result}");
                    Console.Write($"Want to play again? Y/N ");
                    string userInput2 = Console.ReadLine();
                    if (userInput2.Trim().ToLower() == "y" && randomGame == false)
                    {
                        DivisionGame(true);
                    } else if (userInput2.Trim().ToLower() == "y" && randomGame == true)
                    {
                        RandomGame(true);
                    }
                    else if (userInput2.Trim().ToLower() == "n")
                    {
                        play = false;
                    }
                    else
                    {
                        Console.WriteLine($"Type \"Y\" or \"N\"");
                    }
                }
                else
                {
                    Console.WriteLine($"Not correct! Try again");
                }
                break;
            }
        }

        public void RandomGame(bool play)
        {
            int randomNumber = helper.GetRandomNumber(1, 4);
            randomGame = true;
            switch (randomNumber)
            {
                case 1:
                    AdditionGame(true);
                    break;
                case 2:
                    SubtractionGame(true);
                    break;
                case 3:
                    MultiplicationGame(true);
                    break;
                case 4:
                    DivisionGame(true);
                    break;
                default:
                    AdditionGame(true);
                    break;
            }
        }
    }
}
