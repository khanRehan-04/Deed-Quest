using UnityEngine;
using TMPro;

public class DisplayTaskUI : MonoBehaviour
{
    public TMP_Text taskText;
    public TaskManager taskManager;

    void Start()
    {
        DisplayTasks();
    }

    void DisplayTasks()
    {
        string taskInfo = "";

        foreach (Task task in taskManager.tasks)
        {
            taskInfo += "Task: " + task.name + "\nDescription: " + task.description + "\n\n";
        }

        taskText.text = taskInfo;
    }
}
