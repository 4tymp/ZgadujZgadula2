namespace ZgadujZgadula2.MainGameScreen;

public class CheckInput{
    public static int Check(){

        try{
            string? guess = Console.ReadLine();
            
            return Convert.ToInt32(guess);

            
        }
        catch{
            Console.WriteLine($"\nnie podałeś liczby.");
            return Check();
        }

        
    }
}