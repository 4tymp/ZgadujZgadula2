using ZgadujZgadula2.TitleScreen; // Działa, bo MainMenu jest teraz w tym namespace w innym pliku

string selection = "0";

while (selection != "4")
{
    MainMenu.Show();


    if (selection == "1")
    {

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
