using System.Text.Json;

namespace taskManager;

public class JsonHandler
{
    private readonly string _filePath;

    public JsonHandler(string filePath)
    {
        _filePath = filePath;
    }

    
    public void WriteToJson(Task task)
    {
        var options = new JsonSerializerOptions() { WriteIndented = true }; 
        string jsonString = JsonSerializer.Serialize(task, options);
        File.WriteAllText(_filePath, jsonString); 
    }
    
    public List<Task>? ReadFromJson()
    {
        if (!File.Exists(_filePath))
        {
            return []; 
        }

        var jsonString = File.ReadAllText(_filePath); // Read JSON from file
        return JsonSerializer.Deserialize<List<Task>>(jsonString); // Deserialize JSON to List<Task>
    }
}