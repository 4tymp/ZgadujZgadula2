namespace ZgadujZgadula2.MainGameScreen;

class BadGameOver{
    public static void Show(GameSession newGame){
        Console.Clear();
        Console.WriteLine($"Niestety, przekroczyłeś limit strzalow ({newGame.MaxAttempts}) i przegrałeś zakład.");
        Console.WriteLine("Wciśnij Enter, aby wrócić do menu tytułowego.");
        Console.ReadLine();
    }
}