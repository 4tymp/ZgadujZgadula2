using ZgadujZgadula2.SettingsScreen.Languages;

namespace ZgadujZgadula2.SettingsScreen;

public class Settings{
    public bool AskForBetMode {get; private set;} = true;

    public Language CurrentLanguage {get; private set;} = new Polish();

    public void ToggleAskForBetMode(){
        AskForBetMode = !AskForBetMode; // odwraca askforbetmode.
    }

    public void ToggleLanguage(){
        if (CurrentLanguage is Polish){
            CurrentLanguage = new English();
        } else{
            CurrentLanguage = new Polish();
        }
    }
}