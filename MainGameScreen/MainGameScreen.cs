namespace ZgadujZgadula2.MainGameScreen;

public class MainGameScreen{
    public static void Show(GameSession newGame, Difficulty difficulty){
        Console.Clear();
        Console.WriteLine($"Próba nr: {newGame.Attempts}");
        Console.WriteLine($"Zgadnij liczbę w przedziale 1 - {difficulty.Max}");
        if (newGame.MaxAttempts != null){
            Console.WriteLine($"Maksymalna ilosc strzałów: {newGame.MaxAttempts}");
        }
    }
}