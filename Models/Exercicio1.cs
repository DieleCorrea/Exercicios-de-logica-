using System;

namespace Treinando_logica.Models;

public class Exercicio1
{
    public int Item1 { get; set; }
    public int Item2 { get; set; }

    public void calcular()
    {
        Console.WriteLine($"Por favor digite o primeiro numero par  a multiplicação");
        string num1 = Console.ReadLine()!; Item1 = int.Parse( num1 );

        Console.WriteLine($"Agora digite o segundo numero: ");
        string num2 = Console.ReadLine()!; Item2 = int.Parse( num2 );

        Console.WriteLine($"Resultado da multiplicação: {multiplicar()}");
    }

    public int multiplicar() { return Item1 * Item2; }  
}
