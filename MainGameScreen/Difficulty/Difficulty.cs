namespace ZgadujZgadula2.MainGameScreen;

public abstract class Difficulty {
    public abstract string Name { get; }
    public abstract int Max { get; }

    public int GetTarget() => new Random().Next(1, Max + 1);
}