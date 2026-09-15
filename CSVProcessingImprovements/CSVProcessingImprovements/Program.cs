using CSVProcessingImprovements.CsvReading;
using CSVProcessingImprovements.InterfaceSolution;
using CSVProcessingImprovements.Solution;
// using CSVProcessingImprovements.NewSolution;
using CSVProcessingImprovements.PerformanceTesting;

string filePath = "/home/user/Downloads/sampleData (1).csv";
CsvData csvData = new CsvReader().Read(filePath);

ITableDataBuilder tableDataBuilder = new TableDataBuilder();

var _ = TableDataPerformanceMeasurer.Test(tableDataBuilder, csvData);

var testResult = TableDataPerformanceMeasurer.Test(tableDataBuilder, csvData);

Console.WriteLine("Test results for old code:");
Console.WriteLine("Memory increase in bytes: " +
                  string.Format("{0:n0}", testResult.MemoryIncreaseInBytes));
Console.WriteLine($"Time of loading the CSV was " +
                  $"{testResult.TimeOfBuildingTable}.");
Console.WriteLine($"Time of reading the CSV was " +
                  $"{testResult.TimeOfDataReading}.");



ITableDataBuilder fastTableDataBuilder = new FastDataBuilder();

var testResultForNewCode = TableDataPerformanceMeasurer.Test(fastTableDataBuilder, csvData);

Console.WriteLine();
Console.WriteLine("Test results for new code:");
Console.WriteLine("Memory increase in bytes: " +
    string.Format("{0:n0}", testResultForNewCode.MemoryIncreaseInBytes));
Console.WriteLine($"Time of loading the CSV was " +
    $"{testResultForNewCode.TimeOfBuildingTable}.");
Console.WriteLine($"Time of reading the CSV was " +
    $"{testResultForNewCode.TimeOfDataReading}.");

Console.WriteLine();
Console.WriteLine("Checking if results are the same...");
var areEqual = ContentEqualityChecker.IsEqual(
    fastTableDataBuilder, 
    fastTableDataBuilder, 
    csvData);

if(areEqual)
{
    Console.WriteLine("Results are the same.");
}
else
{
    Console.WriteLine("Results are different.");
}

Console.WriteLine("Done. Press any key to close.");
Console.ReadKey();