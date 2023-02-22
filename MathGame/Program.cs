using MathGame;

Menu menu = new Menu();
Console.Title = "Math Game";

menu.CreateMenu();

while (true) {
    Console.Clear(); 
    menu.ChooseGame(); 
}

