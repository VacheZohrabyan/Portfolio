using StarWarsPlanetsStats.Model;

namespace StarWarsPlanetsStats.App;

public interface IPlanetStatisticAnalyzer
{
    public void Analyze(IEnumerable<Planet> planets);
}