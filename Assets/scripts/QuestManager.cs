using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    // List to store active quests
    private List<Quest> activeQuests = new List<Quest>();

    void Start()
    {
        // Example of creating and adding a new quest
        Quest newQuest = new Quest("Find the Lost Sword", "Search the forest and find the lost sword.");
        activeQuests.Add(newQuest);

        // Display quest information
        foreach (var quest in activeQuests)
        {
            Debug.Log("Quest: " + quest.questName + "\nDescription: " + quest.description);
        }
    }

    // Method to complete a quest
    public void CompleteQuest(string questName)
    {
        foreach (var quest in activeQuests)
        {
            if (quest.questName == questName && !quest.isCompleted)
            {
                quest.CompleteQuest();
                Debug.Log("Quest Completed: " + quest.questName);
                return;
            }
        }

        Debug.Log("Quest not found or already completed.");
    }
}
