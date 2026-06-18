using ZgadujZgadula2.MainGameScreen;

namespace ZgadujZgadula2.HallOfFameScreen;

public class HallOfFameScreen {
    public static void Show(HallOfFame hallOfFame) {
        Difficulty difficulty = new Easy(); // domyślnie łatwy

        while (true) {
            HallOfFameDisplay.Show(hallOfFame, difficulty);

            Difficulty? input = HallOfFameInput.HandleInput();

            if (input == null) break;

            difficulty = input;
        }
    }
}