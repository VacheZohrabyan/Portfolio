namespace StarWarsPlanetsStats.Extensions;

public static class StringExtensions
{
    public static int? ToIntOrNull(this string? inputValue)
    {
        return int.TryParse(inputValue, out int resultPassed) ? resultPassed : null;
    }
}