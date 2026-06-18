using ZgadujZgadula2.Utils;
using ZgadujZgadula2.SettingsScreen;
using ZgadujZgadula2.HallOfFameScreen;

namespace ZgadujZgadula2.TitleScreen;

public class MainMenu
{
    public static void Show(Settings settings, HallOfFame hallOfFame){
        Console.Clear();

        ASCII.Title();

        if (hallOfFame.HasEntries()) {
            Console.WriteLine(settings.CurrentLanguage.MainMenuOptions);
        } else {
            Console.WriteLine(settings.CurrentLanguage.MainMenuOptionsNoHallOfFame);
        }
        
        Console.WriteLine(settings.CurrentLanguage.SelectOption);
    }
}
