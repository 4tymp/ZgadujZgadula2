namespace ZgadujZgadula2.SettingsScreen.Languages;

public class Polish : Language {
    // DifficultySelection
    public override string SelectDifficulty => "Wybierz poziom trudności:";
    public override string DifficultyOptions => "1. Łatwy | 2. Średni | 3. Trudny";
    public override string InvalidDifficulty => "Niepoprawny wybór. Wybierz poprawną opcję (1-3):";
    public override string ConfirmDifficulty => "Jesteś pewny, ze chcesz wybrać {0} poziom trudności?\nT/n";

    // MainGameScreen
    public override string AttemptNumber => "Próba nr: {0}";
    public override string GuessNumber => "Zgadnij liczbę w przedziale 1 - {0}";
    public override string MaxAttempts => "Maksymalna ilosc strzałów: {0}";

    // RandomMessages
    public override List<string> RandomMessages => new List<string> {
        "Zła odpowiedź, spróbuj jeszcze raz!",
        "Niestety pudło! Celuj dalej.",
        "Nie tym razem, pomyśl chwilę!",
        "Blisko, ale to wciąż nie to.",
        "Los chciał inaczej. Próbuj dalej!"
    };
    public override string TooHigh => "Strzelasz za wysoko.";
    public override string TooLow => "Strzelasz za nisko.";

    // GameOver
    public override string Congratulations => "Gratulacje! Zgadłeś liczbę w {0} próbach!";
    public override string EnterName => "Podaj swoje imię:";
    public override string ScoreSaved => "Wynik zapisany! Wciśnij Enter aby wrócić do menu.";

    // BadGameOver
    public override string BetLost => "Niestety, przekroczyłeś limit strzałów ({0}) i przegrałeś zakład.";
    public override string PressEnter => "Wciśnij Enter, aby wrócić do menu tytułowego.";

    // BetModeSelection
    public override string BetModeQuestion => "Czy chcesz grać w trybie zakładu?";
    public override string YesNo => "T/n";
    public override string EnterMaxAttempts => "Podaj maksymalną liczbę prób:";

    // HallOfFame
    public override string HallOfFameTitle => "Hall of Fame - {0}";
    public override string NoScores => "Brak wyników dla tego poziomu trudności.";
    public override string HallOfFameOptions => "1. Łatwy | 2. Średni | 3. Trudny | 4. Wyjście";
    public override string Attempts => "Próby";
    public override string Time => "Czas";
    public override string ClearHallOfFameConfirm => "Czy na pewno chcesz wyczyścić Hall of Fame?\nT/n";
    public override string ClearHallOfFameSuccess => "Hall of Fame wyczyszczone!";

    // Settings
    public override string SettingsTitle => "Ustawienia";
    public override string BetModeSetting => "1. Tryb zakładu: {0}";
    public override string BetModeOn => "Włączony";
    public override string BetModeOff => "Wyłączony";
    public override string LanguageSetting => "2. Język: Polski";
    public override string ClearHallOfFame => "3. Wyczyść Hall of Fame";
    public override string Exit => "4. Wyjście";
    public override string InvalidSettings => "Niepoprawny wybór. Wybierz poprawną opcję (1-4):";

    // MainMenu
    public override string MainMenuOptions => "1. Nowa gra | 2. Hall of Fame | 3. Ustawienia | 4. Wyjście";
    public override string SelectOption => "Wybierz poprawną opcję (1-4):";
    

}