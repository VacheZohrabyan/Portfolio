using GameDataParser.UserInteract;
using GameDataParser.Model;
using System.Text.Json;

namespace GameDataParser.DataAccess
{
    public class VideoGameDeserializer : IVideoGameDeserializer
    {
        private readonly IUserInteractor _userInteractor;

        public VideoGameDeserializer(IUserInteractor userInteractor)
        {
            _userInteractor = userInteractor;
        }
    
        public List<VideoGame> DeserializedVideoGame(string fileContents, string fileName)
        {
            try
            { 
                return JsonSerializer.Deserialize<List<VideoGame>>(fileContents);
            }
            catch (JsonException ex)
            {
                _userInteractor.PrintError($"JSON in the {fileName}  was not in a valid format. JSON body:");
                _userInteractor.PrintError(fileContents);
                throw new JsonException($"{ex.Message} The file is: {fileName}", ex);
            }
        }
    }
}