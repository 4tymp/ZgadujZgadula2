using ZgadujZgadula2.HallOfFameScreen;
using ZgadujZgadula2.SettingsScreen;

namespace ZgadujZgadula2.MainGameScreen;

public class NewGame{
        public static void Start(HallOfFame hallOfFame, Settings settings){
            GameSession newGame = new GameSession();

            bool isNewGamePlus = GameModeSelection.Show(settings);

            if (isNewGamePlus) {
            newGame.SetNewGamePlus();
        }

            Difficulty? difficulty = null;
            
            while (difficulty == null)
            {
                DifficultySelection.Show(settings);
                difficulty = DifficultySelection.HandleInput(settings);
            }
            

            if (isNewGamePlus == false) {
                int? maxAttempts = BetModeSelection.Show(settings); // pytanie o trybzakladu
                if (maxAttempts != null) {
                    newGame.ChangeMaxAttempts(maxAttempts);
                }
            }

            int target = difficulty.GetTarget();

            MainGame.Start(target, difficulty, hallOfFame, newGame, settings);
        }    
}