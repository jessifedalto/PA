using System;
using System.Reflection;
public class Program {
    public static void Main (String[] args) {


        try {

            Console.WriteLine ("Choose a number: ");
            float number = float.Parse(Console.ReadLine());

            evenOrOdd(number);

            Console.WriteLine ("\nWhat's your score?");

            float score = float.Parse(Console.ReadLine());

            checkApproval(score);

        } catch (FormatException){
            
            Console.WriteLine("\nInvalid input");
            return;
        }
    
    }

    static void evenOrOdd (float number) {
        Console.WriteLine(number % 2 == 0? "Even" : "Odd");
    }
        
    

    static void checkApproval(float score) {
        Console.WriteLine(score >= 60? "Approved" : "Disapproved");
      
    }
}
