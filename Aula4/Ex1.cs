using System;
using System.Reflection;
public class Program {
    public static void Main (String[] args) {


        try {

            Console.WriteLine ("Choose a number: ");
            float number = float.Parse(Console.ReadLine());

            triple(number);

            Console.WriteLine ("\nHow many kilometers?");

            float km = float.Parse(Console.ReadLine());

            convertKmToMilhas(km);

        } catch (FormatException){
            
            Console.WriteLine("\nInvalid input");
            return;
        }
    
    }

    static void triple (float number) {
        Console.WriteLine("\nTriple of " + number + " = " + (number * 3).ToString("F2"));
    }
        
    

    static void convertKmToMilhas(float km) {
       Console.WriteLine($"\n{km} = {km * 0.621371} milhas");
    }
}
