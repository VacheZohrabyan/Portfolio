using CSVProcessingImprovements.InterfaceSolution;
using CSVProcessingImprovements.CsvReading;

namespace CSVProcessingImprovements.Solution;

public class TableDataBuilder : ITableDataBuilder
{
    public ITableData Build(CsvData csvData)
    {
        List<Row> resultRows = new List<Row>();

        foreach (var data in csvData.Rows)
        {
            Dictionary<string, object> newRowData = new Dictionary<string, object>();

            for (int columnIndex = 0; columnIndex < csvData.Columns.Length; ++columnIndex)
            {
                string column = csvData.Columns[columnIndex];
                string valueAsString = data[columnIndex];
                newRowData[column] = ConvertValueToTargetType(valueAsString);
            }
            resultRows.Add(new Row(newRowData));
        }
        
        return new TableData(csvData.Columns, resultRows);
    }

    private object ConvertValueToTargetType(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            return null;
        }
        else if (value == "TRUE")
        {
            return true;
        }
        else if (value == "FALSE")
        {
            return false;
        }
        else if (value.Contains(".") && decimal.TryParse(value, out decimal valueDecimal))
        {
            return valueDecimal;
        }
        else if (int.TryParse(value, out int valueInteger))
        {
            return valueInteger;
        }

        return value;
    }
}