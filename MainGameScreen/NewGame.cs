namespace ZgadujZgadula2.MainGameScreen;

public class NewGame{
        public static void Start(){
            Difficulty? difficulty = null;
            
            while (difficulty == null)
            {
                DifficultySelection.Show();
                difficulty = DifficultySelection.HandleInput();
            }
            
            int target = difficulty.GetTarget();

            MainGame.Start(target, difficulty);
        }    
}