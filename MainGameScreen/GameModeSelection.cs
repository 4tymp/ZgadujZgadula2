using ZgadujZgadula2.SettingsScreen;
using ZgadujZgadula2.Utils;

namespace ZgadujZgadula2.MainGameScreen;

public class GameModeSelection {
    public static bool Show(Settings settings) {
        Console.Clear();
        ASCII.Title();

        Console.WriteLine(settings.CurrentLanguage.GameModeQuestion);
        Console.WriteLine(settings.CurrentLanguage.GameModeOptions);

        string input = "";
        while (input != "1" && input != "2")
        {
            if (input != "")
            {
                Console.WriteLine(settings.CurrentLanguage.InvalidSettings);
            }
            input = Console.ReadLine()!;
        }

        return input == "2"; //true = ng+
    }
}