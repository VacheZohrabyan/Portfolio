namespace CSVProcessingImprovements.CsvReading
{
    public interface ICsvReader
    {
        CsvData Read(string path);
    }
}