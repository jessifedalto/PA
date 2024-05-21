using System;
public class Program {
    public static void Main (String[] args) {
        
        Console.WriteLine("Qual o valor do raio: ");
        
        float raio = float.Parse(Console.ReadLine());
        
        double area = Math.PI * raio * raio;
        
        Console.WriteLine("\nA área do círculo de raio " + raio + " é igual a " + area.ToString("F2"));

    }
}
