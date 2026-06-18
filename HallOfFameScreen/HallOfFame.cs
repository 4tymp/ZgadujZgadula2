using ZgadujZgadula2.Shared;
using ZgadujZgadula2.MainGameScreen;

namespace ZgadujZgadula2.HallOfFameScreen;

public class HallOfFame{
    private List<ScoreEntry> entries = new List<ScoreEntry>();

    public void Add(ScoreEntry entry){
        entries.Add(entry);
    }

    public List<ScoreEntry> GetTop5(Difficulty difficulty){
        return entries
            // dla każdego wpisu (e) sprawdź czy poziom trudności się zgadza
            .Where(e => e.Difficulty.Name == difficulty.Name)
            // posortuj rosnąco po liczbie prób (mniej prób = wyżej)
            .OrderBy(e => e.Attempts)
            // jeśli liczba prób taka sama, wyżej ten kto zrobił to szybciej
            .ThenBy(e => e.Time)
            // weź tylko pierwszych 5
            .Take(5)
            // zamień wynik na List<ScoreEntry>
            .ToList();
    }
}