using ZgadujZgadula2.Utils;

namespace ZgadujZgadula2.MainGameScreen;

public class DifficultySelection{
    public static void Show(){
        Console.Clear();
        ASCII.Title();

        Console.WriteLine("Wybierz poziom trudności:");

        Console.WriteLine("1. Łatwy | 2. Średni | 3. Trudny");
    }    

    public static string HandleInput(){
        string selection = "";

        while (selection != "1" && selection != "2" && selection != "3")
        {
            if (selection != "")
            {
                Console.WriteLine("Niepoprawny wybór. Wybierz poprawną opcję (1-3):");
            }
            
            selection = Console.ReadLine()!;
        }
        return selection;
    }
}
