namespace WordCounter;

class WordCounter
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite uma ou mais palavras: ");
        List<string> palavras = new List<string>();
        var input = Console.ReadLine();
        if (input == null)
        {
            Console.WriteLine("Nenhuma palavra foi digitada.");
        } else
        {
            palavras = input.Trim().Split(' ').ToList();
            foreach (var palavra in palavras)
            {
                Console.WriteLine($"A palavra '{palavra}' possui {palavra.Length} caracteres.");
            }
        }
    }
}
