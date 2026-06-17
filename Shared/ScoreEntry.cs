using ZgadujZgadula2.MainGameScreen;

namespace ZgadujZgadula2.Shared;

public class ScoreEntry{
    public string PlayerName {get;}
    public Difficulty Difficulty {get;}
    public int Attempts {get;}
    public TimeSpan Time {get;}

    public ScoreEntry(string playerName, Difficulty difficulty, int attempts, TimeSpan time){
        PlayerName = playerName;
        Difficulty = difficulty;
        Attempts = attempts;
        Time = time;
    }

}