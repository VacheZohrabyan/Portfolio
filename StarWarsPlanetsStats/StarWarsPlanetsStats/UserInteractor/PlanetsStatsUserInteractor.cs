using StarWarsPlanetsStats.Model;

namespace StarWarsPlanetsStats.UserInteractor;

public class PlanetsStatsUserInteractor : IPlanetsStatsUserInteractor
{
    private readonly IUserInteractor _userInteractor;

    public PlanetsStatsUserInteractor(IUserInteractor userInteractor)
    {
        _userInteractor = userInteractor;
    }
    
    public void Show(IEnumerable<Planet> planets)
    {
        _userInteractor.PrintTable(planets);
    }

    public string? ChooseStatisticToBeShow(IEnumerable<string> propertyThatCanBeChoose)
    {
        _userInteractor.ShowMessage("");
        _userInteractor.ShowMessage("The statistics of which property would you like to see?");
        _userInteractor.ShowMessage(
            string.Join(Environment.NewLine,
                propertyThatCanBeChoose));
        return _userInteractor.ReadFromUser();
    }

    public void ShowMessage(string message)
    {
        _userInteractor.ShowMessage(message);
    }
}