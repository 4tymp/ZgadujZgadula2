using ZgadujZgadula2.HallOfFameScreen;
using ZgadujZgadula2.Shared;
using ZgadujZgadula2.SettingsScreen;
using ZgadujZgadula2.SettingsScreen.Languages;

namespace ZgadujZgadula2.MainGameScreen;

public class GameOver{
    public static void Show(GameSession session, Settings settings){
        
        Console.Clear();
        Console.WriteLine(string.Format(settings.CurrentLanguage.Congratulations, session.Attempts));
        Console.WriteLine(settings.CurrentLanguage.EnterName);
    

    }

    public static void HandleInput(GameSession session, Difficulty difficulty, HallOfFame hallOfFame, Settings settings){
        string playerName = Console.ReadLine()!;

        ScoreEntry entry = new ScoreEntry(playerName, difficulty, session.Attempts, session.ElapsedTime);
        hallOfFame.Add(entry);

        Console.WriteLine(settings.CurrentLanguage.ScoreSaved);
        Console.ReadLine();
    }
}