namespace ZgadujZgadula2.SettingsScreen;

public class SettingsScreen {
    public static void Show(Settings settings) {
        while (true)
        {
            SettingsDisplay.Show(settings);
            string input = SettingsInput.HandleInput();

            if (input == "1")
            {
                settings.ToggleAskForBetMode();
            }
            else if (input == "2")
            {
                break;
            }
        }
    }
}