using CSVProcessingImprovements.CsvReading;

namespace CSVProcessingImprovements.InterfaceSolution
{
    public interface ITableDataBuilder
    {
        ITableData Build(CsvData csvData);
    }
}