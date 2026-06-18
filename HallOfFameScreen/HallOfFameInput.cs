using ZgadujZgadula2.MainGameScreen;

namespace ZgadujZgadula2.HallOfFameScreen;

public class HallOfFameInput {
    public static Difficulty? HandleInput() {
        string input = "";

        while (input != "1" && input != "2" && input != "3" && input != "4")
        {
            if (input != "")
            {
                Console.WriteLine("\nNiepoprawny wybór. Wybierz poprawną opcję (1-4):");
            }
            input = Console.ReadLine()!;
        }

        if (input == "1") return new Easy();
        else if (input == "2") return new Medium();
        else if (input == "3") return new Hard();
        else return null; // 4 = wyjscie
    }
}