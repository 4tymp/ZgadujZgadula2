using ZgadujZgadula2.HallOfFameScreen;

namespace ZgadujZgadula2.MainGameScreen;

public class MainGame{
    public static void Start(int target, Difficulty difficulty, HallOfFame hallOfFame, GameSession newGame){

        newGame.Start();

        int? guess = null;
        bool badGameOver = false;

        while(guess != target){
            if (newGame.MaxAttempts == null || newGame.MaxAttempts > newGame.Attempts){
                MainGameScreen.Show(newGame, difficulty);

                if (guess != null){
                    ShowRandomMessages.Show(guess, target);
                }

                guess = CheckInput.Check();

                newGame.IncrementAttempts();
            }
            else {
                BadGameOver.Show(newGame);
                badGameOver = true;

                break;
            }
        }

        if (badGameOver == false){
            GameOver.Show(newGame);
            GameOver.HandleInput(newGame, difficulty, hallOfFame);
        }
    }
}