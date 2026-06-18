using ZgadujZgadula2.SettingsScreen;

namespace ZgadujZgadula2.MainGameScreen;

class BadGameOver{
    public static void Show(GameSession newGame, Settings settings){
        Console.Clear();
        Console.WriteLine(string.Format(settings.CurrentLanguage.BetLost, newGame.MaxAttempts));
        Console.WriteLine(settings.CurrentLanguage.PressEnter);
        Console.ReadLine();
    }
}