namespace ZgadujZgadula2.MainGameScreen;

public class MainGame{
    public static void Start(int target, Difficulty difficulty){
        
        bool? goodguess = null;

        while(goodguess != true){
            MainGameScreen.Show(difficulty);

            if (goodguess != null){
                // metoda wyswietlania komunikatu (randommessages)
            }

            goodguess = CheckInput.Check(target);
        }
    }
}