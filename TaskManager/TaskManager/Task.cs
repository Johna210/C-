namespace taskManager;

public class Task
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; }
    public string Description { get; set; }
    public Categories Category { get; set; }
    public bool IsCompleted { get; set; }

    public Task(string name, string description, Categories category, bool isCompleted)
    {
        Name = name;
        Description = description;
        Category = category;
        IsCompleted = isCompleted;
    }

    public Task()
    {
    }

    public override string ToString()
    {
        return $"Id: {Id} Name: {Name}\nDescription: {Description}\nCategory: {Category}";
    }
}
