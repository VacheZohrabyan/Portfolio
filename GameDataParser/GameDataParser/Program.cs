using GameDataParser;
using GameDataParser.App;
using GameDataParser.DataAccess;
using GameDataParser.UserInteract;

IUserInteractor userInteractor = new ConsoleUserInteract();
// IGamesPrinter gamesPrinter = new GamesPrinter(userInteractor);
// IVideoGameDeserializer videoGameDeserializer = new VideoGameDeserializer(userInteractor);
// IFileRider fileRider = new LocalFileRider();

GameDataParserApp gameDataParserApp = new GameDataParserApp(
    userInteractor,
    new GamesPrinter(userInteractor), 
    new VideoGameDeserializer(userInteractor),
    new LocalFileRider());

Logger logger = new Logger("log.txt");

try
{
    gameDataParserApp.Run();
}
catch (Exception ex)
{
    Console.WriteLine("Sorry! The application has experienced an unexpected error " +
        "and will have to be closed.");
    logger.Log(ex);
}    

Console.ReadKey();