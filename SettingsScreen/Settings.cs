namespace ZgadujZgadula2.SettingsScreen;

public class Settings{
    public bool AskForBetMode {get; private set;} = true;

    public void ToggleAskForBetMode(){
        AskForBetMode = !AskForBetMode; // odwraca askforbetmode.
    }
}