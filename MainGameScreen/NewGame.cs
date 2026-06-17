

namespace ZgadujZgadula2.MainGameScreen;

public class NewGame{
        public static void Start(){
            string? difficulty = null;
            
            while (difficulty == null)
            {
                DifficultySelection.Show();
                difficulty = DifficultySelection.HandleInput();
            }
            
            int target = DifficultySelection.RandomNumber(difficulty);

            Console.WriteLine(target);
        }    
}