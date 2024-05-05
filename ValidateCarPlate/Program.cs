namespace ValidateCarPlate;

class ValidateCarPlate 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite a placa de um veículo: ");
        var placa = Console.ReadLine();

        if (string.IsNullOrEmpty(placa))
        {
            Console.WriteLine("A placa informada não é válida.");
        } else
        {
            Console.WriteLine(ValidateLength(placa) && ValidatePrefix(placa) && ValidateSuffix(placa));                  
        }
    }

    private static bool ValidateLength(string placa)
    {
        if (placa.Length != 7)
        {
            Console.WriteLine("A placa deve ter 7 caracteres alfanuméricos");
            return false;
        }
        return true;
    }
    private static bool ValidatePrefix(string placa)
    {
        for (int i = 0; i < 3; i++)
        {
            if (!char.IsLetter(placa[i]))
            {
                Console.WriteLine("Os três primeiros caracteres são letras (maiúsculas ou minúsculas)");
                return false;
            }
        }
        return true;
    }
    private static bool ValidateSuffix(string placa)
    {
        for (int i = 3; i < placa.Length; i++)
        {
            if (!char.IsDigit(placa[i]))
            {
                Console.WriteLine("Os quatro últimos caracteres são números");
                return false;
            }
        }
        return true;
    }
}
