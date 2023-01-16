using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIQuest : MonoBehaviour
{
    public Quest quest;
    public QuestManager questManager;
    public Button acceptButton;
    public Button completeButton;

    private void Start()
    {
        acceptButton.onClick.AddListener(AcceptQuest);
        completeButton.onClick.AddListener(CompleteQuest);
    }

    private void AcceptQuest()
    {
        questManager.AddQuest(quest);
    }

    private void CompleteQuest()
    {
        questManager.CompleteQuest(quest);
    }
}
