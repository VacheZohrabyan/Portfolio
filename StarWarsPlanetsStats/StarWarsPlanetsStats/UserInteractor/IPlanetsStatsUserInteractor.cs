using StarWarsPlanetsStats.Model;

namespace StarWarsPlanetsStats.UserInteractor;

public interface IPlanetsStatsUserInteractor
{
    void Show(IEnumerable<Planet> planets);
    string? ChooseStatisticToBeShow(IEnumerable<string> propertyThatCanBeChoose);
    void ShowMessage(string message);
}