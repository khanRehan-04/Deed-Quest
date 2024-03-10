[System.Serializable]
public class Task
{
    public string name;
    public string description;
    public bool isCompleted;

    // Constructor
    public Task(string name, string description)
    {
        this.name = name;
        this.description = description;
        this.isCompleted = false;
    }
}
