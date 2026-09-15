namespace CSVProcessingImprovements.Solution
{
    public class Row
    {
        private Dictionary<string, object> _data;

        public Row(Dictionary<string, object> data)
        {
            _data = data;
        }

        public object GetAtColumn(string columName)
        {
            return _data[columName];
        }
    }
}
