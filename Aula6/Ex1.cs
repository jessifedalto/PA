using System;
using System.Reflection;
public class Program {
    public static void Main (String[] args) {

        showNumbers();

        sumNumbers();
    
    }

    static void showNumbers () {
        int number = 0;
        while (number < 11) {
            Console.WriteLine (number);
            number++;
        }
    }
        
    static void sumNumbers() {
        int sum = 0;
        for (int i = 1; i < 101; i++) {
            sum += i;
        }
        Console.WriteLine ("Adding the numbers from 0 to 100 is equal to " + sum);
    }
}
