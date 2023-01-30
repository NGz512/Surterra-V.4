using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public QuestManager questManager;
    private int playerMoney;

    private void Start()
    {
        //playerMoney = GameManager.Instance.GetPlayerMoney();
    }

    public void OfferQuest()
    {
        if (questManager.PlayerMoney >= questManager.questPrice)
        {
            questManager.StartQuest();
            // Start conversation with player to start quest
        }
        else
        {
            Debug.Log("Not Enough Money! Need " + questManager.questPrice + " to start quest");
        }
    }

    public void CompleteQuest()
    {
        questManager.CompleteQuest();
        // End conversation with player after quest is completed
    }
}