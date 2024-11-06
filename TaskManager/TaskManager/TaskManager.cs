namespace taskManager;

public class TaskManager
{
    private List<Task>? _tasks;
    private CsvHandler csvHandler = new CsvHandler("tasks.csv");
    private JsonHandler _jsonHandler = new JsonHandler("tasks.json");
    public TaskManager()
    {
        _tasks = [];
    }

    public TaskManager(List<Task> tasks)
    {
        _tasks = tasks;
    }
    
    // Add Task
    public void AddTask(Task task)
    {
        try
        {
            _jsonHandler.WriteToJson(task);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        
        _tasks?.Add(task);
    }
    
    // Update Task
    public void UpdateTask(Guid id,Task task)
    {
        if (_tasks == null) return;
        for (var i = 0; i < _tasks.Count; i++)
        {
            if (_tasks[i].Id == id)
            {
                _tasks[i] = task;
            }
        }
    }
    // Remove Task
    public void RemoveTask(Guid id)
    {
        _tasks?.RemoveAll(task => task.Id == id);
    }
    // Display All Tasks
    public async void DisplayAll()
    {
        Console.WriteLine("Displaying all tasks");
        try
        {
            var tasks = _jsonHandler.ReadFromJson();
            if (tasks == null) return;
            foreach (var task in tasks)
            {
                Console.WriteLine(task);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        
    }

    
    // Display Single Task
    public Task? GetTask(Guid id)
    {
        return _tasks?.FirstOrDefault(task => task.Id == id);
    }

    public override string ToString()
    {
        var allTasks = "";
        if (_tasks == null) return allTasks;
        foreach (var task in _tasks)
        {
            allTasks += task;
            allTasks += "\n.................";
        }

        return allTasks;
    }
}