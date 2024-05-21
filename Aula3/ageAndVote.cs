using System;
using System.Reflection;
public class Program {
    public static void Main (String[] args) {


        try {

            Console.WriteLine ("How old are you? ");
            int age = Int32.Parse(Console.ReadLine());

            votar(age);

            Console.WriteLine ("\nIs it raining?");

            bool itsRaining = Boolean.Parse(Console.ReadLine());

            Console.WriteLine("\nIs it sunny?");

            bool itsSunny = Boolean.Parse(Console.ReadLine());

            itsAGoodDay(itsRaining, itsSunny);

        } catch (FormatException){
            
            Console.WriteLine("\nInvalid input");
            return;
        }
    
    }

    static void votar (int age) {
        if ((age >= 16 && age < 18) || (age >= 60 )) {
            Console.WriteLine("\nOptional vote");
        } else if (age < 16) {
            Console.WriteLine("\nYou can't vote");
        } else {
            Console.WriteLine("\nYou must vote");
        }
    }

    static void itsAGoodDay(bool itsRaining, bool itsSunny) {
        if (itsRaining && itsSunny) {
            Console.WriteLine("\nIt's a good day :) ");
        } else if (itsRaining && !itsSunny){
            Console.WriteLine("\nIt ins't a good day :( ");
        } else {
            Console.WriteLine("\nIt's a good day :) ");

        }
    }
}
