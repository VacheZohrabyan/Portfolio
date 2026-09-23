using StarWarsPlanetsStats.ApiDataAccess;
using StarWarsPlanetsStats.App;
using StarWarsPlanetsStats.UserInteractor;
using StarWarsPlanetsStats.DataAccess;
// https://swapi.dev/api/planets

try
{
    await new StarWarsPlanetsStatApp(
        new PlanetFromApiReader(
            new ApiDataReader(),
            new MockStarWarsApiDataReader(),
            new ConsoleUserInteract()),
        new PlanetStatisticAnalayzer(
            new PlanetsStatsUserInteractor(
                new ConsoleUserInteract())),
        new PlanetsStatsUserInteractor(
            new ConsoleUserInteract())).Run();
}
catch (Exception ex)
{
    Console.WriteLine("An error occurred" +
                      "Exception message: " + ex.Message);
}

Console.ReadKey();