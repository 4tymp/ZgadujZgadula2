using ZgadujZgadula2.MainGameScreen;

namespace ZgadujZgadula2.HallOfFameScreen;

public class HallOfFameInput {
    public static Difficulty? HandleInput() {
        string input = Console.ReadLine()!;

        if (input == "1") return new Easy();
        else if (input == "2") return new Medium();
        else if (input == "3") return new Hard();
        else if (input == "4") return null; // wyjście do menu

        return null;
    }
}