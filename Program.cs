using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Conversor de Temperatura");
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1 - Celsius para Fahrenheit");
        Console.WriteLine("2 - Fahrenheit para Celsius");

        int opcao = int.Parse(Console.ReadLine());

        if (opcao == 1)
        {
            Console.Write("Digite a temperatura em Celsius: ");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = (celsius * 1.8) + 32;
            Console.WriteLine($"{celsius}°C = {fahrenheit}°F");
        }
        else if (opcao == 2)
        {
            Console.Write("Digite a temperatura em Fahrenheit: ");
            double fahrenheit = double.Parse(Console.ReadLine());
            double celsius = (fahrenheit - 32) / 1.8;
            Console.WriteLine($"{fahrenheit}°F = {celsius}°C");
        }
        else
        {
            Console.WriteLine("Opção inválida!");
        }
    }
}
