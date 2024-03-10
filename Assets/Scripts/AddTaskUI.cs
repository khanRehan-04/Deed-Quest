using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AddTaskUI : MonoBehaviour
{
    // References to input fields and button
    public TMP_InputField taskNameInput;
    public TMP_InputField taskDescriptionInput;
    public TaskManager taskManager;

    // Method called when the submit button is clicked
    public void AddTask()
    {
        // Get task name and description from input fields
        string name = taskNameInput.text;
        string description = taskDescriptionInput.text;

        // Add task to TaskManager
        taskManager.AddTask(name, description);

        // Clear input fields
        taskNameInput.text = "";
        taskDescriptionInput.text = "";
    }
}
