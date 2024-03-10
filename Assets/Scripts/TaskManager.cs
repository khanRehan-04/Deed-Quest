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
}
