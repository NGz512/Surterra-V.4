using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SideQuest : MonoBehaviour
{
    private bool isUsed = false;
    public void GiveItem()
    {
        if (!isUsed)
        {
            int itemcode = 10000;
            InventoryLocation inventoryLocation = InventoryLocation.player;

            int itemPosition = InventoryManager.Instance.FindItemInInventory(inventoryLocation, itemcode);

            if (itemPosition != -1)
            {
                //กำหนดรางวัลเงินที่ได้
                InventoryManager.Instance.PlayerMoney += 200;
                // Remove item from inventory
                InventoryManager.Instance.RemoveItem(inventoryLocation, itemcode);
                isUsed = true;
            }
            else
            {
                Debug.Log("Invalid item.");
            }
        }
        else
        {
            Debug.Log("Button already used.");
        }
    }
}
