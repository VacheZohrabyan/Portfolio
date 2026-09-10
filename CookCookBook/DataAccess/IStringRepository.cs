namespace CookCookBook.DataAccess
{
    public interface IStringRepository
    {
        List<string> Read(string filePath);
        void Write(string filePath, List<string> allRecipes);
    }
}