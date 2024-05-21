using System;
using System.Reflection;
public class Program {
    public static void Main (String[] args) {

        matriz();

        determinant();
    
    }

    
        
    static void matriz() {
        int[,] matriz = new int[3, 3];
        int number = 0;
        
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                try {
                    Console.WriteLine("\nChoose a number");
                    number = Int32.Parse (Console.ReadLine());
                } catch (System.Exception) {
                    Console.WriteLine("Invalid");
                }
                
                matriz[i,j] = number;

            }
        }
    
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                
                Console.WriteLine("\t" + matriz[i,j]);

            }
                Console.WriteLine("\n");

        }


    }
    
    static void determinant () {
        int[,] matriz = new int[2, 2];
        int number = 0;
        for (int i = 0; i < 2; i++) {
            for (int j = 0; j < 2; j++) {
                try {
                    Console.WriteLine("\nChoose a number");
                    number = Int32.Parse (Console.ReadLine());
                } catch (System.Exception) {
                    Console.WriteLine("Invalid");
                }
                
                matriz[i,j] = number;

            }
        }
        
        int determinant = (matriz[0,0] * matriz[1,1]) - (matriz[0,1] * matriz[1,0]);
        Console.WriteLine("Determinant = " + determinant);
    }
}
