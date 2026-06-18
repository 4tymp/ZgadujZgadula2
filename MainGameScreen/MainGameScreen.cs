using ZgadujZgadula2.SettingsScreen;

namespace ZgadujZgadula2.MainGameScreen;

public class MainGameScreen{
    public static void Show(GameSession newGame, Difficulty difficulty, Settings settings, int target){
        Console.Clear();

        if (newGame.IsNewGamePlus) {
            Console.WriteLine(settings.CurrentLanguage.NewGamePlus);
            int shotsUntilReroll = difficulty.RerollAfter - (newGame.Attempts % difficulty.RerollAfter);
            Console.WriteLine(string.Format(settings.CurrentLanguage.RerollIn, shotsUntilReroll));
        }

        Console.WriteLine(string.Format(settings.CurrentLanguage.AttemptNumber, newGame.Attempts));
        Console.WriteLine(string.Format(settings.CurrentLanguage.GuessNumber, difficulty.Max));
        if (newGame.MaxAttempts != null){
            Console.WriteLine(string.Format(settings.CurrentLanguage.MaxAttempts, newGame.MaxAttempts));
        }
    }
}