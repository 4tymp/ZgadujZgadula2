using ZgadujZgadula2.Utils;

namespace ZgadujZgadula2.SettingsScreen;

public class SettingsDisplay{
    public static void Show(Settings settings){
        Console.Clear();
        ASCII.Title();

        Console.WriteLine("Ustawienia");
        Console.WriteLine("-----------------------------------");
        
        string betMode;
        if (settings.AskForBetMode)
            betMode = "Włączony";
        else
            betMode = "Wyłączony";

        Console.WriteLine($"1. Tryb zakładu: {betMode}");


        Console.WriteLine("-----------------------------------");
        Console.WriteLine("2. Wyjście");
    }
}