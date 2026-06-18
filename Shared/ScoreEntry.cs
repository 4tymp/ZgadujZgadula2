using ZgadujZgadula2.MainGameScreen;

namespace ZgadujZgadula2.Shared;

public class ScoreEntry{
    public string PlayerName {get;}
    public Difficulty Difficulty {get;}
    public int Attempts {get;}
    public TimeSpan Time {get;}
    public bool IsNewGamePlus { get; }

    public ScoreEntry(string playerName, Difficulty difficulty, int attempts, TimeSpan time, bool isNewGamePlus){
        PlayerName = playerName;
        Difficulty = difficulty;
        Attempts = attempts;
        Time = time;
        IsNewGamePlus = isNewGamePlus;
    }

}