namespace StarWarsPlanetsStats.UserInteractor;

public class ConsoleUserInteract : IUserInteractor
{
    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }

    public string? ReadFromUser()
    {
        return Console.ReadLine();
    }

    public void PrintTable<T>(IEnumerable<T> planets)
    {
        Table.PrintTable(planets);
    }
}