using ZgadujZgadula2.MainGameScreen;
using ZgadujZgadula2.SettingsScreen;

namespace ZgadujZgadula2.HallOfFameScreen;

public class HallOfFameScreen {
    public static void Show(HallOfFame hallOfFame, Settings settings) {
        Difficulty difficulty = new Easy(); // domyślnie łatwy

        while (true) {
            HallOfFameDisplay.Show(hallOfFame, difficulty, settings);

            Difficulty? input = HallOfFameInput.HandleInput();

            if (input == null) break;

            difficulty = input;
        }
    }
}