using ZgadujZgadula2.Utils;
using ZgadujZgadula2.SettingsScreen;

namespace ZgadujZgadula2.TitleScreen;

public class MainMenu
{
    public static void Show(Settings settings){
        Console.Clear();

        ASCII.Title();

        Console.WriteLine(settings.CurrentLanguage.MainMenuOptions);
        Console.WriteLine(settings.CurrentLanguage.SelectOption);
    }
}