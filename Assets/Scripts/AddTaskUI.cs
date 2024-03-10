using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AddTaskUI : MonoBehaviour
{
    public TMP_InputField taskNameInput;
    public TMP_InputField taskDescriptionInput;
    public TaskManager taskManager;
    
    public void AddTask()
    {
        
        string name = taskNameInput.text;
        string description = taskDescriptionInput.text;
        
        taskManager.AddTask(name, description);

        taskNameInput.text = "";
        taskDescriptionInput.text = "";
    }
}
