using ZgadujZgadula2.HallOfFameScreen;
using ZgadujZgadula2.SettingsScreen;

namespace ZgadujZgadula2.MainGameScreen;

public class NewGame{
        public static void Start(HallOfFame hallOfFame, Settings settings){
            Difficulty? difficulty = null;
            
            while (difficulty == null)
            {
                DifficultySelection.Show();
                difficulty = DifficultySelection.HandleInput();
            }
            
            int? maxAttempts = BetModeSelection.Show(settings); //pytanie o tryb zakladu
            int target = difficulty.GetTarget();

            MainGame.Start(target, difficulty, hallOfFame);
        }    
}