using ZgadujZgadula2.HallOfFameScreen;
using ZgadujZgadula2.SettingsScreen;

namespace ZgadujZgadula2.MainGameScreen;

public class MainGame {
    public static void Start(int target, Difficulty difficulty, HallOfFame hallOfFame, GameSession newGame, Settings settings) {
        newGame.Start();

        int? guess = null;
        bool badGameOver = false;

        while (guess != target) {
            if (newGame.MaxAttempts == null || newGame.MaxAttempts > newGame.Attempts) {
                if (newGame.IsNewGamePlus && newGame.Attempts > 0 && newGame.Attempts % difficulty.RerollAfter == 0) {
                    target = difficulty.GetTarget();
                }

                MainGameScreen.Show(newGame, difficulty, settings, target);

                if (guess != null) {
                    ShowRandomMessages.Show(guess, target, settings);
                }

                guess = CheckInput.Check();
                newGame.IncrementAttempts();
            }
            else {
                BadGameOver.Show(newGame, settings);
                badGameOver = true;
                break;
            }
        }

        if (badGameOver == false) {
            GameOver.Show(newGame, settings);
            GameOver.HandleInput(newGame, difficulty, hallOfFame, settings);
        }
    }
}