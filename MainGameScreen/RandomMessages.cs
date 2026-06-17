namespace ZgadujZgadula2.MainGameScreen;

public class RandomMessages{
        private List<string> messages = new List<string>
        {
            "Zła odpowiedź, spróbuj jeszcze raz!",
            "Niestety pudło! Celuj dalej.",
            "Nie tym razem, pomyśl chwilę!",
            "Blisko, ale to wciąż nie to.",
            "Los chciał inaczej. Próbuj dalej!"
        };


        private Random rand = new Random();


        public string LoadMessage()
        {
            int index = rand.Next(messages.Count);
            return messages[index];
        }
    }