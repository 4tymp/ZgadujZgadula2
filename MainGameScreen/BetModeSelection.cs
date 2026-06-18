using ZgadujZgadula2.SettingsScreen;

namespace ZgadujZgadula2.MainGameScreen;

public class BetModeSelection{
    public static int? Show(Settings settings) {
        if (!settings.AskForBetMode) return null;
        
        Console.Clear();
        Console.WriteLine(settings.CurrentLanguage.BetModeQuestion);
        Console.WriteLine(settings.CurrentLanguage.YesNo);

        string input = Console.ReadLine()!;
        if (input == "n") return null;

        Console.WriteLine(settings.CurrentLanguage.EnterMaxAttempts);
        return CheckInput.Check();
    }
}