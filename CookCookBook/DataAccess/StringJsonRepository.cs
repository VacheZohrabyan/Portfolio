using System.Text.Json;

namespace CookCookBook.DataAccess
{
    public class StringJsonRepository : StringRepository
    {
        private static readonly string separator = Environment.NewLine;

        protected override List<string> TextToStrings(string fileContents)
        {
            return JsonSerializer.Deserialize<List<string>>(fileContents)!;
        }
        
        protected override string StringsToText(List<string> strings)
        {
            return JsonSerializer.Serialize(strings);   
        }
    }
}