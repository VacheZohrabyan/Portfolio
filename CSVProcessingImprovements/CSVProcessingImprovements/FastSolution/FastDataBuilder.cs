using CSVProcessingImprovements.CsvReading;

namespace CSVProcessingImprovements.InterfaceSolution
{
    public class FastDataBuilder : ITableDataBuilder
    {
        public ITableData Build(CsvData csvData)
        {
            List<FastRow> resultRows = new List<FastRow>();

            foreach (var data in csvData.Rows)
            {
                FastRow fastRow = new FastRow();
                
                for (int columnIndex = 0; columnIndex < csvData.Columns.Length; ++columnIndex)
                {
                    string column = csvData.Columns[columnIndex];
                    string valueAsString = data[columnIndex];
                    if (string.IsNullOrEmpty(valueAsString))
                    {
                        fastRow.AssignCall(column, null);
                    }
                    else if (valueAsString == "TRUE")
                    {
                        fastRow.AssignCall(column, true);
                    }
                    else if (valueAsString == "FALSE")
                    {
                        fastRow.AssignCall(column, false);
                    }
                    else if (valueAsString.Contains(".") && decimal.TryParse(valueAsString, out decimal valueDecimal))
                    {
                        fastRow.AssignCall(column, valueDecimal);
                    }
                    else if (int.TryParse(valueAsString, out int valueInteger))
                    {
                        fastRow.AssignCall(column, valueInteger);
                    }
                }
                resultRows.Add(fastRow);
            }
        
            return new FastTableData(csvData.Columns, resultRows);
        }
    }
}