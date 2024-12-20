public class Quest
{
    public string questName;
    public string description;
    public bool isCompleted = false;

    // Constructor for easy quest creation
    public Quest(string name, string desc)
    {
        questName = name;
        description = desc;
    }

    // Method to mark the quest as completed
    public void CompleteQuest()
    {
        isCompleted = true;
    }
}
