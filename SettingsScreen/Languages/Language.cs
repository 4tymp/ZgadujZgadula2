namespace ZgadujZgadula2.SettingsScreen.Languages;

public abstract class Language {
    // DifficultySelection
    public abstract string SelectDifficulty { get; }
    public abstract string DifficultyOptions { get; }
    public abstract string InvalidDifficulty { get; }
    public abstract string ConfirmDifficulty { get; }

    // MainGameScreen
    public abstract string AttemptNumber { get; }
    public abstract string GuessNumber { get; }
    public abstract string MaxAttempts { get; }

    // RandomMessages
    public abstract List<string> RandomMessages { get; }
    public abstract string TooHigh { get; }
    public abstract string TooLow { get; }

    // GameOver
    public abstract string Congratulations { get; }
    public abstract string EnterName { get; }
    public abstract string ScoreSaved { get; }

    // BadGameOver
    public abstract string BetLost { get; }
    public abstract string PressEnter { get; }

    // BetModeSelection
    public abstract string BetModeQuestion { get; }
    public abstract string YesNo { get; }
    public abstract string EnterMaxAttempts { get; }

    // HallOfFame
    public abstract string HallOfFameTitle { get; }
    public abstract string NoScores { get; }
    public abstract string HallOfFameOptions { get; }
    public abstract string Attempts { get; }
    public abstract string Time { get; }

    // Settings
    public abstract string SettingsTitle { get; }
    public abstract string BetModeSetting { get; }
    public abstract string BetModeOn { get; }
    public abstract string BetModeOff { get; }
    public abstract string LanguageSetting { get; }
    public abstract string ClearHallOfFame { get; }
    public abstract string Exit { get; }
    public abstract string InvalidSettings { get; }

    // MainMenu
    public abstract string MainMenuOptions { get; }
    public abstract string SelectOption { get; }


}