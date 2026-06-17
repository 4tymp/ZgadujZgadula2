namespace ZgadujZgadula2.MainGameScreen;

public class RandomMessages{
        public List<string> messages = new List<string>
        {
            "Zła odpowiedź, spróbuj jeszcze raz!",
            "Niestety pudło! Celuj dalej.",
            "Nie tym razem, pomyśl chwilę!",
            "Blisko, ale to wciąż nie to.",
            "Los chciał inaczej. Próbuj dalej!"
        };


        public Random rand = new Random();


        public string PobierzWiadomosc()
        {
            int index = rand.Next(messages.Count);
            return messages[index];
        }
    }