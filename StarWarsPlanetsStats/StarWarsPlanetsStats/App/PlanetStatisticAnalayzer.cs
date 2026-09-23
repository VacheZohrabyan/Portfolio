using StarWarsPlanetsStats.Model;
using StarWarsPlanetsStats.UserInteractor;

namespace StarWarsPlanetsStats.App;

public class PlanetStatisticAnalayzer : IPlanetStatisticAnalayzer
{
    private readonly IPlanetsStatsUserInteractor _planetsStatsUserInteractor;
    
    private readonly Dictionary<string, Func<Planet, int?>> _propertyNamesToSelectorMapping =
        new Dictionary<string, Func<Planet, int?>>
        {
            ["population"] = planet => planet.Population,
            ["diameter"] = planet => planet.Diameter,
            ["surface water"] = planet => planet.SurfaceWater
        };
    
    public PlanetStatisticAnalayzer(
        IPlanetsStatsUserInteractor planetsStatsUserInteractor)
    {
        _planetsStatsUserInteractor = planetsStatsUserInteractor;
    }

    public void Analyze(IEnumerable<Planet> planets)
    {
        string? userChoice = 
            _planetsStatsUserInteractor.ChooseStatisticToBeShow(_propertyNamesToSelectorMapping.Keys);

        if (userChoice is null || !_propertyNamesToSelectorMapping.ContainsKey(userChoice))
        {
            Console.WriteLine("Invalid input");
        }
        else
        {
            ShowStatistics(planets, userChoice, _propertyNamesToSelectorMapping[userChoice]);
        }
    }
    
    private static void ShowStatistics(
        IEnumerable<Planet> planets,
        string? propertyName,
        Func<Planet, int?> propertySelector)
    {
        ShowStatistics(
            "Max",
            planets.MaxBy(propertySelector),
            propertySelector,
            propertyName);
        ShowStatistics(
            "Min",
            planets.MinBy(propertySelector),
            propertySelector,
            propertyName);
    }

    private static void ShowStatistics(
        string? descriptor,
        Planet selectedPlanet,
        Func<Planet, int?> propertySelector,
        string? propertyName)
    {
        Console.WriteLine($"{descriptor} {propertyName} is {propertySelector(selectedPlanet)} " +
                          $"(Planet: {selectedPlanet.Name})");
    }
}