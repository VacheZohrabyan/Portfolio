namespace CSVProcessingImprovements.InterfaceSolution
{
    public class FastTableData : ITableData
    {
        private readonly List<FastRow> _rows;
        public int RowCount => _rows.Count;
        public IEnumerable<string> Columns { get; }

        public FastTableData(IEnumerable<string> columns, List<FastRow> rows)
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