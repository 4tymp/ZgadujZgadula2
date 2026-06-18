using ZgadujZgadula2.SettingsScreen;

namespace ZgadujZgadula2.MainGameScreen;

public class BetModeSelection{
    public static int? Show(Settings settings) {
        if (!settings.AskForBetMode) return null;

        Console.WriteLine("\nCzy chcesz grać w trybie zakładu?");
        Console.WriteLine("T/n");

        string input = Console.ReadLine()!;
        if (input == "n") return null;

        Console.WriteLine("Podaj maksymalną liczbę prób:");
        return CheckInput.Check();
    }
}