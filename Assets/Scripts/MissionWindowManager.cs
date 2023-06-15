using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionWindowManager : MonoBehaviour
{
    // Singleton instance
    public static MissionWindowManager Instance { get; private set; }

    // ChecklistItem class
    public class ChecklistItem
    {
        public string itemName;
        public bool isCompleted;

        public ChecklistItem(string name)
        {
            itemName = name;
            isCompleted = false;
        }
    }

    // List of checklist items
    public List<ChecklistItem> checklistItems = new List<ChecklistItem>();

    // UI elements for checklist items
    public List<Toggle> checklistItemToggles = new List<Toggle>();

    private void Awake()
    {
        // Create a singleton instance
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        // Add checklist items
        checklistItems.Add(new ChecklistItem("Find the Fire Extinguisher"));
        checklistItems.Add(new ChecklistItem("Practice P.A.S.S"));
        checklistItems.Add(new ChecklistItem("Put out the fire"));
    }

    // Method to mark an action as completed in the checklist
    public void CompleteAction(string action)
    {
        // Check if the action exists in the checklist
        ChecklistItem item = checklistItems.Find(x => x.itemName == action);
        if (item != null)
        {
            // Update the completion status
            item.isCompleted = true;
        }
    }

    // Optional: Method to reset the checklist
    public void ResetChecklist()
    {
        foreach (Toggle toggle in checklistItemToggles)
        {
            toggle.isOn = false;
        }
    }
}
