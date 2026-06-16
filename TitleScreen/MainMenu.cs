using ZgadujZgadula2.Utils;

namespace ZgadujZgadula2.TitleScreen;

public class MainMenu
{
    public static void Show()
    {
        ASCII.Title();

        Console.WriteLine("1. Nowa gra | 2. Hall of Fame | 3. Ustawienia | 4. Wyjście");
    }
}