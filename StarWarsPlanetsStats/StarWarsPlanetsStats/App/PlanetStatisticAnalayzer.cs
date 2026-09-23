using StarWarsPlanetsStats.Model;
using StarWarsPlanetsStats.UserInteractor;

namespace StarWarsPlanetsStats.App;

public class PlanetStatisticalAnalyzer : IPlanetStatisticAnalyzer
{
    private readonly IPlanetsStatsUserInteractor _planetsStatsUserInteractor;
    
    private readonly Dictionary<string, Func<Planet, long?>> _propertyNamesToSelectorMapping =
        new Dictionary<string, Func<Planet, long?>>
        {
            ["population"] = planet => planet.Population,
            ["diameter"] = planet => planet.Diameter,
            ["surface water"] = planet => planet.SurfaceWater
        };
    
    public PlanetStatisticalAnalyzer(
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
        Func<Planet, long?> propertySelector)
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
        Func<Planet, long?> propertySelector,
        string? propertyName)
    {
        Console.WriteLine($"{descriptor} {propertyName} is {propertySelector(selectedPlanet)} " +
                          $"(Planet: {selectedPlanet.Name})");
    }
}