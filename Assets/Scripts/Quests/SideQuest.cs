using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SideQuest : MonoBehaviour
{
    public NPCQuest npcQuest;
    private bool isUsed = false;
    public void GiveItem()
    {
        if (!isUsed)
        {
            int itemcode = 10058;
            InventoryLocation inventoryLocation = InventoryLocation.player;

            int itemPosition = InventoryManager.Instance.FindItemInInventory(inventoryLocation, itemcode);

            if (itemPosition != -1)
            {
                //กำหนดรางวัลเงินที่ได้
                InventoryManager.Instance.PlayerMoney += 150;
                // Remove item from inventory
                InventoryManager.Instance.RemoveItem(inventoryLocation, itemcode);
                isUsed = false;
                //npcQuest.QuestCompleted();
                
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

    public void GiveItem1()
    {
        if (!isUsed)
        {
            int itemcode = 10059;
            InventoryLocation inventoryLocation = InventoryLocation.player;

            int itemPosition = InventoryManager.Instance.FindItemInInventory(inventoryLocation, itemcode);

            if (itemPosition != -1)
            {
                //กำหนดรางวัลเงินที่ได้
                InventoryManager.Instance.PlayerMoney += 500;
                // Remove item from inventory
                InventoryManager.Instance.RemoveItem(inventoryLocation, itemcode);
                isUsed = false;
                //npcQuest.QuestCompleted();

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

    public void GiveItem2()
    {
        if (!isUsed)
        {
            int itemcode = 10060;
            InventoryLocation inventoryLocation = InventoryLocation.player;

            int itemPosition = InventoryManager.Instance.FindItemInInventory(inventoryLocation, itemcode);

            if (itemPosition != -1)
            {
                //กำหนดรางวัลเงินที่ได้
                InventoryManager.Instance.PlayerMoney += 200;
                // Remove item from inventory
                InventoryManager.Instance.RemoveItem(inventoryLocation, itemcode);
                isUsed = false;
                //npcQuest.QuestCompleted();

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

    public void GiveItem3()
    {
        if (!isUsed)
        {
            int itemcode = 10061;
            InventoryLocation inventoryLocation = InventoryLocation.player;

            int itemPosition = InventoryManager.Instance.FindItemInInventory(inventoryLocation, itemcode);

            if (itemPosition != -1)
            {
                //กำหนดรางวัลเงินที่ได้
                InventoryManager.Instance.PlayerMoney += 250;
                // Remove item from inventory
                InventoryManager.Instance.RemoveItem(inventoryLocation, itemcode);
                isUsed = false;
                //npcQuest.QuestCompleted();

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

    public void GiveItem4()
    {
        if (!isUsed)
        {
            int itemcode = 10062;
            InventoryLocation inventoryLocation = InventoryLocation.player;

            int itemPosition = InventoryManager.Instance.FindItemInInventory(inventoryLocation, itemcode);

            if (itemPosition != -1)
            {
                //กำหนดรางวัลเงินที่ได้
                InventoryManager.Instance.PlayerMoney += 350;
                // Remove item from inventory
                InventoryManager.Instance.RemoveItem(inventoryLocation, itemcode);
                isUsed = false;
                //npcQuest.QuestCompleted();

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

    public void GiveItem5()
    {
        if (!isUsed)
        {
            int itemcode = 10063;
            InventoryLocation inventoryLocation = InventoryLocation.player;

            int itemPosition = InventoryManager.Instance.FindItemInInventory(inventoryLocation, itemcode);

            if (itemPosition != -1)
            {
                //กำหนดรางวัลเงินที่ได้
                InventoryManager.Instance.PlayerMoney += 300;
                // Remove item from inventory
                InventoryManager.Instance.RemoveItem(inventoryLocation, itemcode);
                isUsed = false;
                //npcQuest.QuestCompleted();

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

    public void GiveItem6()
    {
        if (!isUsed)
        {
            int itemcode = 10064;
            InventoryLocation inventoryLocation = InventoryLocation.player;

            int itemPosition = InventoryManager.Instance.FindItemInInventory(inventoryLocation, itemcode);

            if (itemPosition != -1)
            {
                //กำหนดรางวัลเงินที่ได้
                InventoryManager.Instance.PlayerMoney += 600;
                // Remove item from inventory
                InventoryManager.Instance.RemoveItem(inventoryLocation, itemcode);
                isUsed = false;
                //npcQuest.QuestCompleted();

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

    public void GiveItem7()
    {
        if (!isUsed)
        {
            int itemcode = 10065;
            InventoryLocation inventoryLocation = InventoryLocation.player;

            int itemPosition = InventoryManager.Instance.FindItemInInventory(inventoryLocation, itemcode);

            if (itemPosition != -1)
            {
                //กำหนดรางวัลเงินที่ได้
                InventoryManager.Instance.PlayerMoney += 400;
                // Remove item from inventory
                InventoryManager.Instance.RemoveItem(inventoryLocation, itemcode);
                isUsed = false;
                //npcQuest.QuestCompleted();

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
