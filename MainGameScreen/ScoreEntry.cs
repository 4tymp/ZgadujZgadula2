namespace ZgadujZgadula2.MainGameScreen;

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