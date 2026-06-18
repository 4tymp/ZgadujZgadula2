namespace ZgadujZgadula2.MainGameScreen;

public abstract class Difficulty {
    public abstract string Name { get; }
    public abstract int Max { get; }

    public abstract int RerollAfter { get; }

    public int GetTarget() => new Random().Next(1, Max + 1);
}