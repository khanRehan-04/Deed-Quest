using System.Collections.Generic;
using UnityEngine;

public class TaskManager : MonoBehaviour
{
    public List<Task> tasks = new List<Task>();

    public void AddTask(string name, string description)
    {
        Task newTask = new Task(name, description);
        tasks.Add(newTask);
    }

    public void UpdateTaskCompletionStatus(Task task)
    {
        Debug.Log("Task completion status updated: " + task.name + " - Completed: " + task.isCompleted);
    }
}
