using UnityEngine;

[System.Serializable]
public class Quest
{
    public string questName;
    public string questDescription;
    public int questID;
    public bool questCompleted;
    public QuestObjective[] questObjectives;
}

[System.Serializable]
public class QuestObjective
{
    public string objective;
    public bool completed;
}