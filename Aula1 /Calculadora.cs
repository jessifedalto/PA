using System;
public class Program {
    public static void Main (String[] args) {
        float num1 = float.Parse(Console.ReadLine());
        float num2 = float.Parse(Console.ReadLine());

        Console.WriteLine("A soma de " + num1 + " + " + num2 + " = " + (num1 + num2) + "\n");
        Console.WriteLine("A subtração de " + num1 + " - " + num2 + " = " + (num1 - num2) + "\n");
        Console.WriteLine("A multiplicação de " + num1 + " * " + num2 + " = " + (num1 * num2) + "\n");
        Console.WriteLine("A divisão de " + num1 + " / " + num2 + " = " + (num1 / num2) + "\n");
        
    }
}
