using ZgadujZgadula2.TitleScreen; 
using ZgadujZgadula2.MainGameScreen;
using ZgadujZgadula2.HallOfFameScreen;
using ZgadujZgadula2.SettingsScreen;

HallOfFame hallOfFame = new HallOfFame();
Settings settings = new Settings();

string selection = "0";

while (true)
{
    MainMenu.Show(settings);


    if (selection == "1")
    {
        NewGame.Start(hallOfFame, settings);
        selection = "0";
        continue;
    }
    else if (selection == "2")
    {
        HallOfFameScreen.Show(hallOfFame, settings);
        selection = "0"; //zeby nie klikac dwa razy 4 po wyjsciu z hall of fame
        continue;
    }
    else if (selection == "3")
    {
        SettingsScreen.Show(settings);
        selection = "0";
        continue;
    }
    else if (selection == "4")
    {
        break;
    }
    
    selection = Console.ReadLine()!;
}

return 0;
