using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class QuestManager : MonoBehaviour
{
    public static QuestManager instance;
    public List<Quest> currentQuests = new List<Quest>();
    public List<Quest> completedQuests = new List<Quest>();

    private void Awake()
    {
        instance = this;
    }

    public void AddQuest(Quest newQuest)
    {
        currentQuests.Add(newQuest);
    }

    public void CompleteQuest(Quest completedQuest)
    {
        currentQuests.Remove(completedQuest);
        completedQuests.Add(completedQuest);
    }
}