using ZgadujZgadula2.TitleScreen; 
using ZgadujZgadula2.MainGameScreen;

string selection = "0";

while (selection != "4")
{
    MainMenu.Show();


    if (selection == "1")
    {
        NewGame.Start();
    }
    else if (selection == "2")
    {

    }
    else if (selection == "3")
    {

    }
    else
    {
        selection = Console.ReadLine()!;
    }
}

return 0;
