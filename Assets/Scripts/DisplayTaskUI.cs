using UnityEngine;
using UserData;

public class DisplayTaskUI : MonoBehaviour
{
    public TaskManager taskManager;
    public GameObject taskUIPrefab;
    public Transform contentPanel;

    void Start()
    {
        DisplayTasks();
    }

    //private void Update()
    //{
    //    DisplayTasks();
    //}

    void DisplayTasks()
    {
        foreach (Task task in taskManager.tasks)
        {
            GameObject taskObject = Instantiate(taskUIPrefab, contentPanel);
            TaskUI taskUI = taskObject.GetComponent<TaskUI>();
            taskUI.Setup(task, taskManager);
        }
    }
}
