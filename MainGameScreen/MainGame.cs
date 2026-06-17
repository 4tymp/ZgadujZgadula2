namespace ZgadujZgadula2.MainGameScreen;

public class MainGame{
    public static void Start(int target, Difficulty difficulty){
        GameSession newGame = new GameSession();

        newGame.Start();

        bool? goodguess = null;

        while(goodguess != true){
            MainGameScreen.Show(newGame, difficulty);

            if (goodguess != null){
                // metoda wyswietlania komunikatu (randommessages)
            }

            goodguess = CheckInput.Check(target);

            newGame.IncrementAttempts();
        }
    }
}