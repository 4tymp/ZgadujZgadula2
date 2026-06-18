using ZgadujZgadula2.HallOfFameScreen;

namespace ZgadujZgadula2.SettingsScreen;

public class SettingsScreen {
    public static void Show(Settings settings, HallOfFame hallOfFame) {
        while (true)
        {
            SettingsDisplay.Show(settings);
            string input = SettingsInput.HandleInput(settings);

            if (input == "1")
            {
                settings.ToggleAskForBetMode();
            }
            else if (input == "2")
            {
                settings.ToggleLanguage();
            }
            else if (input == "3")
            {
                hallOfFame.Clear(settings);
            }
            else if (input == "4")
            {
                break;
            }
        }
    }
}