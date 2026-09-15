using CSVProcessingImprovements.InterfaceSolution;

namespace CSVProcessingImprovements.Solution
{
    public class TableData : ITableData
    {
        private readonly List<Row> _rows;
        public int RowCount => _rows.Count;
        public IEnumerable<string> Columns { get; }

        public TableData(IEnumerable<string> columns, List<Row> rows)
        {
            Columns = columns;
            _rows = rows;
        }
        
        public object GetValue(string columnName, int rowIndex)
        {
            return _rows[rowIndex].GetAtColumn(columnName);
        }
    }
}