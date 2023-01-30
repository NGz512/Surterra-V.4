using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public int questPrice = 100000;
    public int PlayerMoney;

    public void StartQuest()
    {
        if (PlayerMoney >= questPrice)
        {
            PlayerMoney -= questPrice;
            Debug.Log("Quest Started! Remaining Money: " + PlayerMoney);
        }
        else
        {
            Debug.Log("Not Enough Money! Need " + questPrice + " to start quest");
        }
    }

    public void CompleteQuest()
    {
        Debug.Log("Quest Completed!");
    }
}
