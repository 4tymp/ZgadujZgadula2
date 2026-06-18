using ZgadujZgadula2.SettingsScreen;

namespace ZgadujZgadula2.MainGameScreen;

public class MainGameScreen{
    public static void Show(GameSession newGame, Difficulty difficulty, Settings settings){
        Console.Clear();
        Console.WriteLine(string.Format(settings.CurrentLanguage.AttemptNumber, newGame.Attempts));
        Console.WriteLine(string.Format(settings.CurrentLanguage.GuessNumber, difficulty.Max));
        if (newGame.MaxAttempts != null){
            Console.WriteLine(string.Format(settings.CurrentLanguage.MaxAttempts, newGame.MaxAttempts));
        }
    }
}