namespace Wellcome;

class Wellcome
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite seu nome: ");
        var nome = Console.ReadLine();
        Console.WriteLine($"Olá, {nome}! Seja muito bem-vindo!");
    }
}