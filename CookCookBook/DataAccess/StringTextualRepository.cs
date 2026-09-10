namespace CookCookBook.DataAccess
{
    public class StringTextualRepository : StringRepository
    {
        private static readonly string separator = Environment.NewLine;

        protected override List<string> TextToStrings(string fileContents)
        {
            return fileContents.Split(separator).ToList();
        }

        protected override string StringsToText(List<string> strings)
        {
            return string.Join(separator, strings);   
        }
    }
}