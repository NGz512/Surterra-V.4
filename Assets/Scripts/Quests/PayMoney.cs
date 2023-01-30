using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PayMoney : MonoBehaviour
{
    public int paymentAmount = 100000;

    public void Pay()
    {
        if (InventoryManager.Instance.PlayerMoney >= paymentAmount)
        {
            InventoryManager.Instance.PlayerMoney -= paymentAmount;
            CompleteQuest();
        }
        else
        {
            Debug.Log("Not enough money.");
        }
    }

    private void CompleteQuest()
    {
        // Code to complete the quest goes here.
    }
}
