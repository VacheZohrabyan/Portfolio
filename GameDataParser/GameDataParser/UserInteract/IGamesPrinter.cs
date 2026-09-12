using GameDataParser.Model;

namespace GameDataParser.UserInteract
{
    public interface IGamesPrinter
    {
        public void Print(List<VideoGame> videoGames);
    }
}