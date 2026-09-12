using GameDataParser.Model;

namespace GameDataParser.DataAccess
{
    public interface IVideoGameDeserializer
    {
        public List<VideoGame> DeserializedVideoGame(string fileContents, string fileName);
    }
}