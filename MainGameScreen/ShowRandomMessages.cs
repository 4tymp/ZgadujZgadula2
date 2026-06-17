namespace ZgadujZgadula2.MainGameScreen;

public class ShowRandomMessages{
    public static void Show(int? guess, int target){
        RandomMessages message = new RandomMessages(); 


        string higherlowermessage;

        if (guess > target){
            higherlowermessage = " Strzelasz za wysoko.";
        }else{
            higherlowermessage = " Strzelasz za nisko.";
        }
        Console.WriteLine(message.LoadMessage() + higherlowermessage);

        
    }
}