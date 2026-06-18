using ZgadujZgadula2.HallOfFameScreen;
using ZgadujZgadula2.SettingsScreen;

namespace ZgadujZgadula2.MainGameScreen;

public class NewGame{
        public static void Start(HallOfFame hallOfFame, Settings settings){
            GameSession newGame = new GameSession();

            Difficulty? difficulty = null;
            
            while (difficulty == null)
            {
                DifficultySelection.Show(settings);
                difficulty = DifficultySelection.HandleInput(settings);
            }
            
            int? maxAttempts = BetModeSelection.Show(settings); //pytanie o tryb zakladu

            if (maxAttempts != null){
                newGame.ChangeMaxAttempts(maxAttempts);
            }
            int target = difficulty.GetTarget();

            MainGame.Start(target, difficulty, hallOfFame, newGame, settings);
        }    
}