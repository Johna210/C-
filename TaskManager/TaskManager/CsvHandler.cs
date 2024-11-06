namespace taskManager;

public class CsvHandler(string filePath)
{
    public void WriteToCsv(List<object> records)
    {
        if (records == null) throw new ArgumentNullException(nameof(records));
        using var writer = new StreamWriter(filePath, false);
        foreach (var record in records)
        {
            writer.WriteLine(string.Join(",", record)); 
        }
    }
}