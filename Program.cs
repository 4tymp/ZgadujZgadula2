using ZgadujZgadula2.TitleScreen; 
using ZgadujZgadula2.MainGameScreen;
using ZgadujZgadula2.HallOfFameScreen;
using ZgadujZgadula2.SettingsScreen;

HallOfFame hallOfFame = new HallOfFame();
Settings settings = new Settings();

string selection = "0";

while (true){
    MainMenu.Show(settings, hallOfFame);

    if (selection == "1")
    {
        NewGame.Start(hallOfFame, settings);
        selection = "0";
        continue;
    }
    else if (selection == "2" && hallOfFame.HasEntries())
    {
        HallOfFameScreen.Show(hallOfFame, settings);
        selection = "0";
        continue;
    }
    else if ((selection == "3" && hallOfFame.HasEntries()) || (selection == "2" && !hallOfFame.HasEntries()))
    {
        SettingsScreen.Show(settings, hallOfFame);
        selection = "0";
        continue;
    }
    else if ((selection == "4" && hallOfFame.HasEntries()) || (selection == "3" && !hallOfFame.HasEntries()))
    {
        break;
    }

    selection = Console.ReadLine()!;
}

return 0;
