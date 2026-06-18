using ZgadujZgadula2.SettingsScreen;

namespace ZgadujZgadula2.MainGameScreen;

public class RandomMessages {
    private List<string> messages;
    private Random rand = new Random();

    public RandomMessages(Settings settings) {
        messages = settings.CurrentLanguage.RandomMessages;
    }

    public string LoadMessage() {
        int index = rand.Next(messages.Count);
        return messages[index];
    }
}