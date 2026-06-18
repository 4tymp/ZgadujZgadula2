using ZgadujZgadula2.HallOfFameScreen;

namespace ZgadujZgadula2.MainGameScreen;

public class MainGame{
    public static void Start(int target, Difficulty difficulty, HallOfFame hallOfFame, GameSession newGame){

        newGame.Start();

        int? guess = null;

        while(guess != target){
            MainGameScreen.Show(newGame, difficulty);

            if (guess != null){
                ShowRandomMessages.Show(guess, target);
            }

            guess = CheckInput.Check();

            newGame.IncrementAttempts();
        }

        GameOver.Show(newGame);
        GameOver.HandleInput(newGame, difficulty, hallOfFame);
    }
}