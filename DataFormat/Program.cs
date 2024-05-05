using System.Globalization;

namespace DateFormat;

public enum DataFormats
{
    Completo = 0,
    ApenasData = 1,
    ApenasHora = 2,
    PorExtenso = 3,
}

class DateFormat
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Informe o formato de exibição da data atual: ");
        Console.WriteLine("0 - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos).");
        Console.WriteLine("1 - Apenas a data no formato \"01/03/2024\"");
        Console.WriteLine("2 - Apenas a hora no formato de 24 horas.");
        Console.WriteLine("3 - A data com o mês por extenso.");

        var dateFormat = Convert.ToInt32(Console.ReadLine());
        switch (dateFormat) 
        {
            case (int)DataFormats.Completo:
                Console.WriteLine(DateTime.Now.ToString("U", new CultureInfo("pt-BR")));
                break;
            case (int)DataFormats.ApenasData:
                Console.WriteLine(DateTime.Now.Date.ToString("d", new CultureInfo("pt-BR")));
                break;
            case (int)DataFormats.ApenasHora:
                Console.WriteLine(DateTime.Now.ToString("T", new CultureInfo("pt-BR")));
                break;
            case (int)DataFormats.PorExtenso:
                Console.WriteLine(DateTime.Now.Date.ToString("d/MMMM/yyyy", new CultureInfo("pt-BR")));
                break;
            default:
                Console.WriteLine("Formato de data informado é inválido");
                break;

            
        }
        
    }
}