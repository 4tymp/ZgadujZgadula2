namespace ZgadujZgadula2.SettingsScreen.Languages;

public class English : Language {
    // DifficultySelection
    public override string SelectDifficulty => "Select difficulty:";
    public override string DifficultyOptions => "1. Easy | 2. Medium | 3. Hard";
    public override string InvalidDifficulty => "Invalid choice. Select a valid option (1-3):";
    public override string ConfirmDifficulty => "Are you sure you want to select {0} difficulty?\nY/n";

    // MainGameScreen
    public override string AttemptNumber => "Attempt nr: {0}";
    public override string GuessNumber => "Guess a number between 1 - {0}";
    public override string MaxAttempts => "Maximum attempts: {0}";

    // RandomMessages
    public override List<string> RandomMessages => new List<string> {
        "Wrong answer, try again!",
        "Miss! Keep going.",
        "Not this time, think a moment!",
        "Close, but not quite.",
        "Fate had other plans. Keep trying!"
    };
    public override string TooHigh => "Too high.";
    public override string TooLow => "Too low.";

    // GameOver
    public override string Congratulations => "Congratulations! You guessed the number in {0} attempts!";
    public override string EnterName => "Enter your name:";
    public override string ScoreSaved => "Score saved! Press Enter to return to the menu.";

    // BadGameOver
    public override string BetLost => "Unfortunately, you exceeded the attempt limit ({0}) and lost the bet.";
    public override string PressEnter => "Press Enter to return to the main menu.";

    // BetModeSelection
    public override string BetModeQuestion => "Do you want to play in bet mode?";
    public override string YesNo => "Y/n";
    public override string EnterMaxAttempts => "Enter maximum number of attempts:";

    // HallOfFame
    public override string HallOfFameTitle => "Hall of Fame - {0}";
    public override string NoScores => "No scores for this difficulty level.";
    public override string HallOfFameOptions => "1. Easy | 2. Medium | 3. Hard | 4. Exit";
    public override string Attempts => "Attempts";
    public override string Time => "Time";

    // Settings
    public override string SettingsTitle => "Settings";
    public override string BetModeSetting => "1. Bet mode: {0}";
    public override string BetModeOn => "Enabled";
    public override string BetModeOff => "Disabled";
    public override string Exit => "2. Exit";

    // MainMenu
    public override string MainMenuOptions => "1. New game | 2. Hall of Fame | 3. Settings | 4. Exit";
    public override string SelectOption => "Select a valid option (1-4):";
}