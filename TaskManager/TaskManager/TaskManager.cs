namespace taskManager;

public class TaskManager
{
    private List<Task>? _tasks;

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
    public void DisplayAll()
    {
        if (_tasks == null || !_tasks.Any())
        {
            Console.WriteLine("No tasks available.");
            return;
        }

        Console.WriteLine("Tasks:");
        foreach (var task in _tasks)
        {
            Console.WriteLine(task.ToString());
            Console.WriteLine("......................");
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