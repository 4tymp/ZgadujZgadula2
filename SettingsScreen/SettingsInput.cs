namespace ZgadujZgadula2.SettingsScreen;

public class SettingsInput {
    public static string HandleInput(Settings settings) {
        string input = "";

        while (input != "1" && input != "2" && input != "3" && input != "4")
        {
            if (input != "")
            {
                Console.WriteLine(settings.CurrentLanguage.InvalidSettings);
            }
            input = Console.ReadLine()!;
        }

        return input;
    }
}