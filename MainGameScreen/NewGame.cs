

namespace ZgadujZgadula2.MainGameScreen;

public class NewGame{
        public static void Start(){
            
            DifficultySelection.Show();
            string difficulty = DifficultySelection.HandleInput();

            
        }    
}