using ZgadujZgadula2.Shared;
using ZgadujZgadula2.MainGameScreen;
using ZgadujZgadula2.Utils;

namespace ZgadujZgadula2.HallOfFameScreen;

public class HallOfFameDisplay {
    public static void Show(HallOfFame hallOfFame, Difficulty difficulty) {
        Console.Clear();
        ASCII.Title();

        Console.WriteLine($"Hall of Fame - {difficulty.Name}");
        
        Console.WriteLine("---------------------------------------------");

        List<ScoreEntry> top5 = hallOfFame.GetTop5(difficulty);

        if (top5.Count == 0) {
        Console.WriteLine("Brak wyników dla tego poziomu trudności.");
        }else{
            int place = 1;
            foreach (ScoreEntry entry in top5) {
                Console.WriteLine($"{place}. {entry.PlayerName} | Próby: {entry.Attempts} | Czas: {entry.Time.TotalSeconds:F1}s");
                place++;
            }
        }

        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("1. Łatwy | 2. Średni | 3. Trudny | 4. Wyjście");

    }
}