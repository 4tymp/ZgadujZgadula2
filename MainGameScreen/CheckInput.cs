namespace ZgadujZgadula2.MainGameScreen;

public class CheckInput{
    public static bool Check(int target){

        try{
            string? strguess = Console.ReadLine();
            
            int guess = Convert.ToInt32(strguess);

            if (guess == target){
            return true;
            }else{
                return false;
            }
        }
        catch{
            Console.WriteLine($"\nnie podałeś liczby.");
            return Check(target);
        }

        
    }
}