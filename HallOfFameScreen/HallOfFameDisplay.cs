using ZgadujZgadula2.Shared;
using ZgadujZgadula2.MainGameScreen;
using ZgadujZgadula2.Utils;
using ZgadujZgadula2.SettingsScreen;

namespace ZgadujZgadula2.HallOfFameScreen;

public class HallOfFameDisplay {
    public static void Show(HallOfFame hallOfFame, Difficulty difficulty, Settings settings) {
        Console.Clear();
        ASCII.Title();

        Console.WriteLine(string.Format(settings.CurrentLanguage.HallOfFameTitle, difficulty.Name));
        
        Console.WriteLine("---------------------------------------------");

        List<ScoreEntry> top5 = hallOfFame.GetTop5(difficulty);

        if (top5.Count == 0) {
        Console.WriteLine(settings.CurrentLanguage.NoScores);
        }else{
            int place = 1;
            foreach (ScoreEntry entry in top5) {
                Console.WriteLine($"{place}. {entry.PlayerName} | {settings.CurrentLanguage.Attempts}: {entry.Attempts} | {settings.CurrentLanguage.Time}: {entry.Time.TotalSeconds:F1}s");
                place++;
            }
        }

        Console.WriteLine("---------------------------------------------");
        Console.WriteLine(settings.CurrentLanguage.HallOfFameOptions);

    }
}