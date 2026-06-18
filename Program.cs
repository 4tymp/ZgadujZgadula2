using ZgadujZgadula2.TitleScreen; 
using ZgadujZgadula2.MainGameScreen;
using ZgadujZgadula2.HallOfFameScreen;

HallOfFame hallOfFame = new HallOfFame();

string selection = "0";

while (true)
{
    MainMenu.Show();


    if (selection == "1")
    {
        NewGame.Start(hallOfFame);
    }
    else if (selection == "2")
    {
        HallOfFameScreen.Show(hallOfFame);
    }
    else if (selection == "3")
    {

    }
    else if (selection == "4")
    {
        break;
    }
    
    selection = Console.ReadLine()!;
}

return 0;
