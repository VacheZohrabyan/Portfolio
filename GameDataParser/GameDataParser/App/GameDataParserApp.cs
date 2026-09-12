using GameDataParser.DataAccess;
using GameDataParser.UserInteract;
using GameDataParser.Model;

namespace GameDataParser.App
{
    class GameDataParserApp
    {
        private readonly IUserInteractor _userInteractor;
        private readonly IGamesPrinter _gamesPrinter;
        private readonly IVideoGameDeserializer _videoGameDeserializer;
        private readonly IFileRider _fileRider;
    
        public GameDataParserApp(
            IUserInteractor userInteractor, 
            IGamesPrinter gamesPrinter, 
            IVideoGameDeserializer videoGameDeserializer,
            IFileRider fileRider)
        {
            _userInteractor = userInteractor;
            _gamesPrinter = gamesPrinter;
            _videoGameDeserializer = videoGameDeserializer;
            _fileRider = fileRider;
        }
    
        public void Run()
        {
            string path = _userInteractor.ReadValidFile();
            string fileContents = _fileRider.Read(path);
            List<VideoGame> videoGameFrom = _videoGameDeserializer.DeserializedVideoGame(fileContents, path);
            _gamesPrinter.Print(videoGameFrom);
        }
    }
}