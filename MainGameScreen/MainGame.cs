namespace ZgadujZgadula2.MainGameScreen;

public class MainGame{
    public static void Start(int target, Difficulty difficulty){
        GameSession newGame = new GameSession();

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

        // dodawanie do hall of fame
    }
}