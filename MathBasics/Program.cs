namespace MathBasics;

class MathBasics
{
    public static void Main()
    {
        double firstNumber = 12.98;
        double secondeNumber = 8.94;

        Console.WriteLine($"Soma: {firstNumber + secondeNumber}");
        Console.WriteLine($"Subtração: {firstNumber - secondeNumber}");
        Console.WriteLine($"Multiplicação: {firstNumber * secondeNumber}");
        if (secondeNumber != 0)
        {
            Console.WriteLine($"Divisão: {firstNumber / secondeNumber}");
        } else
        {
            Console.WriteLine("Divisão indeterminada");
        }
        Console.WriteLine($"Média: {(firstNumber + secondeNumber) / 2}");        
    }
}