namespace ZgadujZgadula2.MainGameScreen;

public class GameSession {
    private int attempts;
    private DateTime startTime;


    public int Attempts => attempts; // strzalka = tylko do odczytu, nie edytujesz attempts

    public TimeSpan ElapsedTime => DateTime.Now - startTime; // oblicza czas trwania gry (aktualny czas - czas startu gry)


    public void Start(){
        startTime = DateTime.Now; // ustawiamy czas startu gry na aktualny czas
    }
    public void IncrementAttempts(){
        attempts++;
    }
}