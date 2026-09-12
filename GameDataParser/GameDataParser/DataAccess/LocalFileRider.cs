namespace GameDataParser.DataAccess
{
    public class LocalFileRider : IFileRider
    {
        public string Read(string path)
        {
            return File.ReadAllText(path);
        }
    }
}