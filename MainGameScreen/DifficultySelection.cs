using ZgadujZgadula2.Utils;
using ZgadujZgadula2.SettingsScreen;

namespace ZgadujZgadula2.MainGameScreen;

public class DifficultySelection{
    public static void Show(Settings settings){
        Console.Clear();
        ASCII.Title();

        Console.WriteLine(settings.CurrentLanguage.SelectDifficulty);

        Console.WriteLine(settings.CurrentLanguage.DifficultyOptions);
    }    

    public static Difficulty? HandleInput(Settings settings){
        string selection = "";

        while (selection != "1" && selection != "2" && selection != "3")
        {
            if (selection != "")
            {
                Console.WriteLine(settings.CurrentLanguage.InvalidDifficulty);
            }

            selection = Console.ReadLine()!;
        }


        Difficulty chosen;

        if (selection == "1") chosen = new Easy();
        else if (selection == "2") chosen = new Medium();
        else chosen = new Hard();

        Console.WriteLine(string.Format(settings.CurrentLanguage.ConfirmDifficulty, chosen.Name));

        string confirm = Console.ReadLine()!;
        if (confirm == "n") return null;

        return chosen;
        
    }

}
