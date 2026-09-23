namespace StarWarsPlanetsStats.Extensions;

public static class StringExtensions
{
    public static int? ToIntOrNull(this string? inputValue)
    {
        return int.TryParse(inputValue, out int resultPassed) ? resultPassed : null;
    } 
    public static long? ToLongOrNull(this string? inputValue)
    {
        return long.TryParse(inputValue, out long resultPassed) ? resultPassed : null;
    }
}