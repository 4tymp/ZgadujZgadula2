using ZgadujZgadula2.HallOfFameScreen;
using ZgadujZgadula2.Shared;

namespace ZgadujZgadula2.MainGameScreen;

public class GameOver{
    public static void Show(GameSession session){
        
        Console.Clear();
        Console.WriteLine($"\ngratulacje! zgadłeś liczbę w {session.Attempts} próbach!");
        Console.WriteLine($"Podaj swoje imię:");
    

    }

    public static void HandleInput(GameSession session, Difficulty difficulty, HallOfFame hallOfFame){
        string playerName = Console.ReadLine()!;

        ScoreEntry entry = new ScoreEntry(playerName, difficulty, session.Attempts, session.ElapsedTime);
        hallOfFame.Add(entry);

        Console.WriteLine("\nWynik zapisany! Wciśnij Enter aby wrócić do menu.");
        Console.ReadLine();
    }
}