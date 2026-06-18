using ZgadujZgadula2.SettingsScreen;

namespace ZgadujZgadula2.MainGameScreen;

public class ShowRandomMessages{
    public static void Show(int? guess, int target, Settings settings){
        RandomMessages message = new RandomMessages(settings); 


        string higherlowermessage;

        if (guess > target){
            higherlowermessage = settings.CurrentLanguage.TooHigh;
        }else{
            higherlowermessage = settings.CurrentLanguage.TooLow;
        }
        Console.WriteLine(message.LoadMessage() + " " + higherlowermessage);

        
    }
}