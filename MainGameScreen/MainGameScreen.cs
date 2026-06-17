namespace ZgadujZgadula2.MainGameScreen;

public class MainGameScreen{
    public static void Show(Difficulty difficulty){
        Console.Clear();
        Console.WriteLine($"Zgadnij liczbę w przedziale 1 - {difficulty.Max}");
    }
}