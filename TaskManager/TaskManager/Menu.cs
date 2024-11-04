namespace taskManager;

public class Menu
{
    private static TaskManager TaskManager;
    
    public static void Start()
    {
        Console.WriteLine("Welcome to the task manager!");
        TaskManager = new TaskManager();
    }

    public static void PromptAddTask()
    {
        var newTask = new Task();
        Console.WriteLine("Add task: ");
        Console.Write("Task name: ");
        var taskName = Console.ReadLine() ?? "Name";
        
        Console.Write("Task Description: ");
        var description = Console.ReadLine() ?? "description";
        
        Console.Write("Task Status t for completed f for not completed: ");
        var taskStatus = Console.ReadLine()?.ToUpper() == "T" ? true : false;

        
        Console.Write("Task Category: w for work, p for personal, e for errands: ");
        var category = Console.ReadLine() ?? "w";

        newTask.Category = category.ToUpper() switch
        {
            "W" => Categories.Work,
            "P" => Categories.Personal,
            _ => Categories.Errands
        };

        newTask.Name = taskName;
        newTask.Description = description;
        newTask.IsCompleted = taskStatus;
        
        AddTask(newTask);
        
        Console.WriteLine("Task added!");
        Console.WriteLine("_________________________");
    }

    public static void PromotRemoveTask()
    {
        Console.WriteLine("Enter the id of the task you want to delete: ");
        var id = Console.ReadLine();

        if (id == null) return;
        var uuid = new Guid(id);
        TaskManager.RemoveTask(uuid);

    }
     
    public static void PromptDisplayAll()
    {
        TaskManager.DisplayAll();
    }

    public static void PromptGetTask()
    {
        Console.WriteLine("Enter the id of the task you want to view: ");
        var id = Console.ReadLine();

        if (id == null) return;
        var uuid = new Guid(id);
        TaskManager.GetTask(uuid);
    }

    public static void PromptEditTask()
    {
        Console.WriteLine("Enter the id of the task you want to edit: ");
        var id = Console.ReadLine();
        
        if (id == null) return;
        var uuid = new Guid(id);
        
        Console.WriteLine("Enter a new Title: ");
        var newName = Console.ReadLine();
        
        Console.WriteLine("Enter a new Description: ");
        var newDescription = Console.ReadLine();
        
        Console.WriteLine("Enter a new task status t for completed f for not completed: ");
        var newStatus = Console.ReadLine()?.ToUpper() == "T" ? true : false;
        
        
        var editedTask = new Task();
        
        Console.Write("Task Category: w for work, p for personal, e for errands: ");
        var category = Console.ReadLine() ?? "w";

        editedTask.Category = category.ToUpper() switch
        {
            "W" => Categories.Work,
            "P" => Categories.Personal,
            _ => Categories.Errands
        };

        editedTask.Description = newDescription;
        editedTask.IsCompleted = newStatus;
        editedTask.Name = newName;
        
        TaskManager.UpdateTask(uuid, editedTask);
    }
    
    private static void AddTask(Task task)
    {
        TaskManager.AddTask(task);
    }

    public static void RemoveTask(Guid taskId)
    {
        TaskManager.RemoveTask(taskId);
    }
}
