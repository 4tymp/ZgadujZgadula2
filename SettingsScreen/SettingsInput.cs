namespace ZgadujZgadula2.SettingsScreen;

public class SettingsInput {
    public static string HandleInput() {
        string input = "";

        while (input != "1" && input != "2")
        {
            if (input != "")
            {
                Console.WriteLine("\nNiepoprawny wybór. Wybierz poprawną opcję (1-2):");
            }
            input = Console.ReadLine()!;
        }

        return input;
    }
}