using System;
using System.Reflection;
public class Program {
    public static void Main (String[] args) {

        array();

        avarageArray();
    
    }

    
        
    static void array() {
        int[] array = new int[5];

        int number = 0;
        
        for (int i = 0; i < 5; i++) {
            try {
                Console.WriteLine("\nChoose a number");
                number = Int32.Parse (Console.ReadLine());
            }
            catch (System.Exception) {
                Console.WriteLine("Invalid");
            }
            array[i] = number;
        }
    
        for (int j = 4; j >= 0 ; j--) {
            Console.WriteLine("\n" + array[j]);
        }

    }
    
    static void avarageArray () {
        int[] array = new int[10];
        int sum = 0;

        int number = 0;
        
        for (int i = 0; i < 10; i++) {
            try {
                Console.WriteLine("\nChoose a number");
                number = Int32.Parse (Console.ReadLine());
                sum += number;
            }
            catch (System.Exception) {
                Console.WriteLine("Invalid");
            }
            array[i] = number;
        }
    
        Console.WriteLine("Avarage = " + (sum/10));
    }
}
