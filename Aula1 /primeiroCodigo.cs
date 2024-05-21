using System;
public class Program {
    public static void Main (String[] args) {


        try {

            Console.WriteLine ("Digite o valor para o primeiro número: ");
            float num1 = float.Parse(Console.ReadLine());
        
            Console.WriteLine ("\nDigite o valor para o segundo número: ");
            float num2 = float.Parse(Console.ReadLine());

            calculadora(num1, num2);
        
            Console.WriteLine("\nQual o valor do raio: ");
            
            float raio = float.Parse(Console.ReadLine());
            
            areaCirculo(raio);

        } catch (FormatException){
            
            Console.WriteLine("Entrada inválida");
            return;
        }

        

    
    }

    static void calculadora(float num1, float num2) {

        Console.WriteLine("A soma de " + num1 + " + " + num2 + " = " + (num1 + num2) + "\n");
        
        Console.WriteLine("A subtração de " + num1 + " - " + num2 + " = " + (num1 - num2) + "\n");
        
        Console.WriteLine("A multiplicação de " + num1 + " * " + num2 + " = " + (num1 * num2) + "\n");
        
        Console.WriteLine("A divisão de " + num1 + " / " + num2 + " = " + (num1 / num2) + "\n");
    }

    static void areaCirculo(float raio) {

        double area = Math.PI * raio * raio;
        
        Console.WriteLine("\nA área do círculo de raio " + raio + " é igual a " + area.ToString("F2"));
    }
}
