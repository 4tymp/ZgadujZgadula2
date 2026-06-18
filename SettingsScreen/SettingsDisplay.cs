using ZgadujZgadula2.Utils;

namespace ZgadujZgadula2.SettingsScreen;

public class SettingsDisplay{
    public static void Show(Settings settings){
        Console.Clear();
        ASCII.Title();

        Console.WriteLine(settings.CurrentLanguage.SettingsTitle);
        Console.WriteLine("-----------------------------------");
        
        string betMode;
        if (settings.AskForBetMode)
            betMode = settings.CurrentLanguage.BetModeOn;
        else
            betMode = settings.CurrentLanguage.BetModeOff;

        Console.WriteLine(string.Format(settings.CurrentLanguage.BetModeSetting, betMode));



        Console.WriteLine("-----------------------------------");
        Console.WriteLine(settings.CurrentLanguage.Exit);
    }
}