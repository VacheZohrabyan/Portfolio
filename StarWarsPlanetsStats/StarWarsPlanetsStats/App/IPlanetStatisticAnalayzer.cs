using StarWarsPlanetsStats.Model;

namespace StarWarsPlanetsStats.App;

public interface IPlanetStatisticAnalayzer
{
    public void Analyze(IEnumerable<Planet> planets);
}