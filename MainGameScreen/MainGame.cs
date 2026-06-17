namespace ZgadujZgadula2.MainGameScreen;

public class MainGame{
    public static void Start(int target, Difficulty difficulty){
        
        Console.Clear();
        Console.WriteLine("Zgadnij liczbę!");

        Console.WriteLine(target); //usun!

        int attempt = -1;// wartosc ktorej nie da sie osiagnac losowaniem zeby wejsc do petli

        while (attempt != target)
        {
            Console.WriteLine("Podaj liczbę:");
            attempt = int.Parse(Console.ReadLine()!);

            if (attempt < target)
            {
                Console.WriteLine("Za mało!");
            }
            else if (attempt > target)
            {
                Console.WriteLine("Za dużo!");
            }
        }

        Console.WriteLine($"Gratulacje! Zgadłeś liczbę! Wynosiła: {target}");
    }
}