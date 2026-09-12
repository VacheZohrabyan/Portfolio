namespace GameDataParser.UserInteract
{
    public interface IUserInteractor
    {
        void PrintError(string message);
        void PrintMessage(string message);
        string ReadValidFile();
    }
}