namespace FullName;

class FullName
{
    public static void Main()
    {
        Console.WriteLine("Digite seu nome: ");
        var nome = Console.ReadLine();
        Console.WriteLine("Digite seu sobrenome: ");
        var sobrenome = Console.ReadLine();

        Console.WriteLine($"Nome completo: {nome} {sobrenome}");
    }
}