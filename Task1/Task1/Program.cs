class ClassTask
{
    public static void Main()
    {
        Converter converter = new();

        Console.WriteLine(converter.AznConverter(Currency.USD, 1000));
    }
}

public enum Currency
{
    USD,
    EUR,
    TRY,
    RUB
}

public class Converter
{
    public double AznConverter(Currency currency, int azn)
    {
        double value = currency switch
        {
            Currency.USD => 0.59 * azn,
            Currency.EUR => 0.53 * azn,
            Currency.TRY => 8.73 * azn,
            Currency.RUB => 52.21 * azn,
            _ => 0
        };
        return value;
    }
}
