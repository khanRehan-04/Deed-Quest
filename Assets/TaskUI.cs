using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UserData;

public class TaskUI : MonoBehaviour
{
    public TextMeshProUGUI taskText;
    public Toggle completionToggle;

    private Task task;
    private TaskManager taskManager;

    public void Setup(Task task, TaskManager taskManager)
    {
        this.task = task;
        this.taskManager = taskManager;
        taskText.text = task.name + "\n" + task.description;
        completionToggle.isOn = task.isCompleted;
        completionToggle.onValueChanged.AddListener(OnCompletionValueChanged);
    }

    private void OnCompletionValueChanged(bool isCompleted)
    {
        task.isCompleted = isCompleted;
        taskManager.UpdateTaskCompletionStatus(task);
    }
}
