using StarWarsPlanetsStats.UserInteractor;
using StarWarsPlanetsStats.DataAccess;
using StarWarsPlanetsStats.Model;

namespace StarWarsPlanetsStats.App;

public class StarWarsPlanetsStatApp
{
    private readonly IPlanetsReader _planetsReader;
    private readonly IPlanetStatisticAnalayzer _planetStatisticAnalyzer;
    private readonly IPlanetsStatsUserInteractor _planetsStatsUserInteractor;
    public StarWarsPlanetsStatApp(
        IPlanetsReader planetsReader,
        IPlanetStatisticAnalayzer planetStatisticAnalyzer, IPlanetsStatsUserInteractor planetsStatsUserInteractor)
    {
        _planetsReader = planetsReader;
        _planetStatisticAnalyzer = planetStatisticAnalyzer;
        _planetsStatsUserInteractor = planetsStatsUserInteractor;
    }

    public async Task Run()
    {
        IEnumerable<Planet> planets = await _planetsReader.Read();
        
        _planetsStatsUserInteractor.Show(planets);

        _planetStatisticAnalyzer.Analyze(planets);
        
    }
}