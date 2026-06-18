namespace ZgadujZgadula2.MainGameScreen;

public class GameSession {
    private int attempts;
    private DateTime startTime;


    public int Attempts => attempts; // strzalka = tylko do odczytu, nie edytujesz attempts
    private int? MaxAttempts = null;

    public TimeSpan ElapsedTime => DateTime.Now - startTime; // oblicza czas trwania gry (aktualny czas - czas startu gry)


    public void Start(){
        startTime = DateTime.Now;
    }
    public void IncrementAttempts(){
        attempts++;
    }

    public void ChangeMaxAttempts(int? newMaxAttempts){
        MaxAttempts = newMaxAttempts;
    }
}