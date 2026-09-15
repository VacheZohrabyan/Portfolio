namespace CSVProcessingImprovements.InterfaceSolution
{
    public class FastRow
    {
        private Dictionary<string, bool> _boolsData = new();
        private Dictionary<string, int> _intsData = new();
        private Dictionary<string, decimal> _decimalsData = new();
        private Dictionary<string, string> _stringsData = new();

        public void AssignCall(string columnName, bool value)
        {
            _boolsData[columnName] = value;
        }
        
        public void AssignCall(string columnName, int value)
        {
            _intsData[columnName] = value;
        }
        
        public void AssignCall(string columnName, decimal value)
        {
            _decimalsData[columnName] = value;
        }
        
        public void AssignCall(string columnName, string value)
        {
            _stringsData[columnName] = value;
        }

        public object GetAtColumn(string columName)
        {
            if (_boolsData.ContainsKey(columName))
            {
                return _boolsData[columName];
            }
            else if (_intsData.ContainsKey(columName))
            {
                return _intsData[columName];
            }
            else if (_decimalsData.ContainsKey(columName))
            {
                return _decimalsData[columName];
            }
            else if (_stringsData.ContainsKey(columName))
            {
                return _stringsData[columName];
            }

            return null;
        }
    }
}