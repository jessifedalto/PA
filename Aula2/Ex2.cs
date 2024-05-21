using System;
using System.Reflection;
public class Ex2 {
    public static void Main (String[] args) {


        try {

            Console.WriteLine ("Digite o valor para o primeiro número: ");
            float num1 = float.Parse(Console.ReadLine());
        
            Console.WriteLine ("\nDigite o valor para o segundo número: ");
            float num2 = float.Parse(Console.ReadLine());

            maior(num1, num2);

            iguais(num1, num2);


        } catch (FormatException){
            
            Console.WriteLine("\nEntrada inválida");
            return;
        }

    
    }

    static void maior(float num1, float num2) {
        if (num1 > num2) {
            Console.WriteLine("\nO número " + num1 + " é maior");
        } else if (num2 > num1) {
            Console.WriteLine("\nO número " + num2 + " é maior");
        } else {
            Console.WriteLine("\nOs núemeros são iguais");
        }
    }

    static void iguais (float num1, float num2) {
        if (num1 == num2) {
            Console.WriteLine("\nOs números são iguais");
        } else {
            Console.WriteLine("\nOs números são diferentes");
        }

    }
}
