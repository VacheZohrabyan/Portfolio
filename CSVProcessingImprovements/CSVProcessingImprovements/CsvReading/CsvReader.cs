namespace CSVProcessingImprovements.CsvReading
{
    public class CsvReader : ICsvReader
    {
        public CsvData Read(string path)
        {
            using StreamReader streamReader = new StreamReader(path);
            const string separator = ",";

            string[] columns = streamReader.ReadLine().Split(separator);
            List<string[]> rows = new List<string[]>();

            while (!streamReader.EndOfStream)
            {
                string[] cellsInRow = streamReader.ReadLine().Split(separator);
                rows.Add(cellsInRow);
            }

            return new CsvData(columns, rows);
        }
    }
}