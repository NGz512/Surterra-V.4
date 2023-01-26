using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_Shop : MonoBehaviour
{
    private Transform container;
    private Transform shopItemTemplate;
    SO_ItemList sO_ItemList;

    private void Awake()
    {
        container = transform.Find("container");
        shopItemTemplate = container.Find("shopItemTemplate");
        shopItemTemplate.gameObject.SetActive(false);
    }
    public void BuyButton()
    {
        if(InventoryManager.Instance.PlayerMoney >= 10)
        {
            //กำหนดซื้อของร้านค้า
            InventoryManager.Instance.PlayerMoney -= 10;
            // Add item to inventory
            InventoryManager.Instance.AddItem(InventoryLocation.player, 10000);
        }
    }
    public void BuyButton1()
    {
        if (InventoryManager.Instance.PlayerMoney >= 40)
        {
            //กำหนดซื้อของร้านค้า
            InventoryManager.Instance.PlayerMoney -= 40;
            // Add item to inventory
            InventoryManager.Instance.AddItem(InventoryLocation.player, 10003);
        }
    }

    public void BuyButton2()
    {
        if (InventoryManager.Instance.PlayerMoney >= 15)
        {
            //กำหนดซื้อของร้านค้า
            InventoryManager.Instance.PlayerMoney -= 15;
            // Add item to inventory
            InventoryManager.Instance.AddItem(InventoryLocation.player, 10004);
        }
    }

    public void BuyButton3()
    {
        if (InventoryManager.Instance.PlayerMoney >= 20)
        {
            //กำหนดซื้อของร้านค้า
            InventoryManager.Instance.PlayerMoney -= 20;
            // Add item to inventory
            InventoryManager.Instance.AddItem(InventoryLocation.player, 10005);
        }
    }

    public void BuyButton4()
    {
        if (InventoryManager.Instance.PlayerMoney >= 25)
        {
            //กำหนดซื้อของร้านค้า
            InventoryManager.Instance.PlayerMoney -= 25;
            // Add item to inventory
            InventoryManager.Instance.AddItem(InventoryLocation.player, 10008);
        }
    }

    public void BuyButton5()
    {
        if (InventoryManager.Instance.PlayerMoney >= 30)
        {
            //กำหนดซื้อของร้านค้า
            InventoryManager.Instance.PlayerMoney -= 30;
            // Add item to inventory
            InventoryManager.Instance.AddItem(InventoryLocation.player, 10009);
        }
    }

    public void BuyButton6()
    {
        if (InventoryManager.Instance.PlayerMoney >= 35)
        {
            //กำหนดซื้อของร้านค้า
            InventoryManager.Instance.PlayerMoney -= 35;
            // Add item to inventory
            InventoryManager.Instance.AddItem(InventoryLocation.player, 10012);
        }
    }

    public void BuyButton7()
    {
        if (InventoryManager.Instance.PlayerMoney >= 50)
        {
            //กำหนดซื้อของร้านค้า
            InventoryManager.Instance.PlayerMoney -= 50;
            // Add item to inventory
            InventoryManager.Instance.AddItem(InventoryLocation.player, 10013);
        }
    }

    public void BuyButton8()
    {
        if (InventoryManager.Instance.PlayerMoney >= 2400)
        {
            //กำหนดซื้อของร้านค้า
            InventoryManager.Instance.PlayerMoney -= 2400;
            // Add item to inventory
            InventoryManager.Instance.AddItem(InventoryLocation.player, 10033);
        }
    }

    public void BuyButton9()
    {
        if (InventoryManager.Instance.PlayerMoney >= 2400)
        {
            //กำหนดซื้อของร้านค้า
            InventoryManager.Instance.PlayerMoney -= 2400;
            // Add item to inventory
            InventoryManager.Instance.AddItem(InventoryLocation.player, 10035);
        }
    }

    public void BuyButton10()
    {
        if (InventoryManager.Instance.PlayerMoney >= 2400)
        {
            //กำหนดซื้อของร้านค้า
            InventoryManager.Instance.PlayerMoney -= 2400;
            // Add item to inventory
            InventoryManager.Instance.AddItem(InventoryLocation.player, 10037);
        }
    }

    public void BuyButton11()
    {
        if (InventoryManager.Instance.PlayerMoney >= 2400)
        {
            //กำหนดซื้อของร้านค้า
            InventoryManager.Instance.PlayerMoney -= 2400;
            // Add item to inventory
            InventoryManager.Instance.AddItem(InventoryLocation.player, 10039);
        }
    }

    public void BuyButton12()
    {
        if (InventoryManager.Instance.PlayerMoney >= 2400)
        {
            //กำหนดซื้อของร้านค้า
            InventoryManager.Instance.PlayerMoney -= 2400;
            // Add item to inventory
            InventoryManager.Instance.AddItem(InventoryLocation.player, 10041);
        }
    }

    public void SellButton()
    {
        int itemCode = 10016;  // กำหนดค่า itemCode ที่ต้องการที่จะเอาออก
        InventoryLocation inventoryLocation = InventoryLocation.player;  // กำหนดตำแหน่งของ inventory ที่ต้องการเช็ค

        int itemPosition = InventoryManager.Instance.FindItemInInventory(inventoryLocation, itemCode);  // ใช้คำสั่ง FindItemInInventory เพื่อเช็คว่า itemCode นี้มีใน inventory หรือไม่

        if (itemPosition != -1)
        {
            //กำหนดขายของในร้านค้า
            InventoryManager.Instance.PlayerMoney += 15;
            // Remove item from inventory
            InventoryManager.Instance.RemoveItem(inventoryLocation, itemCode);
        }
    }

    public void SellButton1()
    {
        int itemCode = 10019;  // กำหนดค่า itemCode ที่ต้องการที่จะเอาออก
        InventoryLocation inventoryLocation = InventoryLocation.player;  // กำหนดตำแหน่งของ inventory ที่ต้องการเช็ค

        int itemPosition = InventoryManager.Instance.FindItemInInventory(inventoryLocation, itemCode);  // ใช้คำสั่ง FindItemInInventory เพื่อเช็คว่า itemCode นี้มีใน inventory หรือไม่

        if (itemPosition != -1)
        {
            //กำหนดขายของในร้านค้า
            InventoryManager.Instance.PlayerMoney += 50;
            // Remove item from inventory
            InventoryManager.Instance.RemoveItem(inventoryLocation, itemCode);
        }
    }

    public void SellButton2()
    {
        int itemCode = 10020;  // กำหนดค่า itemCode ที่ต้องการที่จะเอาออก
        InventoryLocation inventoryLocation = InventoryLocation.player;  // กำหนดตำแหน่งของ inventory ที่ต้องการเช็ค

        int itemPosition = InventoryManager.Instance.FindItemInInventory(inventoryLocation, itemCode);  // ใช้คำสั่ง FindItemInInventory เพื่อเช็คว่า itemCode นี้มีใน inventory หรือไม่

        if (itemPosition != -1)
        {
            //กำหนดขายของในร้านค้า
            InventoryManager.Instance.PlayerMoney += 20;
            // Remove item from inventory
            InventoryManager.Instance.RemoveItem(inventoryLocation, itemCode);
        }
    }

    public void SellButton3()
    {
        int itemCode = 10021;  // กำหนดค่า itemCode ที่ต้องการที่จะเอาออก
        InventoryLocation inventoryLocation = InventoryLocation.player;  // กำหนดตำแหน่งของ inventory ที่ต้องการเช็ค

        int itemPosition = InventoryManager.Instance.FindItemInInventory(inventoryLocation, itemCode);  // ใช้คำสั่ง FindItemInInventory เพื่อเช็คว่า itemCode นี้มีใน inventory หรือไม่

        if (itemPosition != -1)
        {
            //กำหนดขายของในร้านค้า
            InventoryManager.Instance.PlayerMoney += 25;
            // Remove item from inventory
            InventoryManager.Instance.RemoveItem(inventoryLocation, itemCode);
        }
    }

    public void SellButton4()
    {
        int itemCode = 10024;  // กำหนดค่า itemCode ที่ต้องการที่จะเอาออก
        InventoryLocation inventoryLocation = InventoryLocation.player;  // กำหนดตำแหน่งของ inventory ที่ต้องการเช็ค

        int itemPosition = InventoryManager.Instance.FindItemInInventory(inventoryLocation, itemCode);  // ใช้คำสั่ง FindItemInInventory เพื่อเช็คว่า itemCode นี้มีใน inventory หรือไม่

        if (itemPosition != -1)
        {
            //กำหนดขายของในร้านค้า
            InventoryManager.Instance.PlayerMoney += 30;
            // Remove item from inventory
            InventoryManager.Instance.RemoveItem(inventoryLocation, itemCode);
        }
    }

    public void SellButton5()
    {
        int itemCode = 10025;  // กำหนดค่า itemCode ที่ต้องการที่จะเอาออก
        InventoryLocation inventoryLocation = InventoryLocation.player;  // กำหนดตำแหน่งของ inventory ที่ต้องการเช็ค

        int itemPosition = InventoryManager.Instance.FindItemInInventory(inventoryLocation, itemCode);  // ใช้คำสั่ง FindItemInInventory เพื่อเช็คว่า itemCode นี้มีใน inventory หรือไม่

        if (itemPosition != -1)
        {
            //กำหนดขายของในร้านค้า
            InventoryManager.Instance.PlayerMoney += 35;
            // Remove item from inventory
            InventoryManager.Instance.RemoveItem(inventoryLocation, itemCode);
        }
    }

    public void SellButton6()
    {
        int itemCode = 10028;  // กำหนดค่า itemCode ที่ต้องการที่จะเอาออก
        InventoryLocation inventoryLocation = InventoryLocation.player;  // กำหนดตำแหน่งของ inventory ที่ต้องการเช็ค

        int itemPosition = InventoryManager.Instance.FindItemInInventory(inventoryLocation, itemCode);  // ใช้คำสั่ง FindItemInInventory เพื่อเช็คว่า itemCode นี้มีใน inventory หรือไม่

        if (itemPosition != -1)
        {
            //กำหนดขายของในร้านค้า
            InventoryManager.Instance.PlayerMoney += 40;
            // Remove item from inventory
            InventoryManager.Instance.RemoveItem(inventoryLocation, itemCode);
        }
    }

    public void SellButton7()
    {
        int itemCode = 10029;  // กำหนดค่า itemCode ที่ต้องการที่จะเอาออก
        InventoryLocation inventoryLocation = InventoryLocation.player;  // กำหนดตำแหน่งของ inventory ที่ต้องการเช็ค

        int itemPosition = InventoryManager.Instance.FindItemInInventory(inventoryLocation, itemCode);  // ใช้คำสั่ง FindItemInInventory เพื่อเช็คว่า itemCode นี้มีใน inventory หรือไม่

        if (itemPosition != -1)
        {
            //กำหนดขายของในร้านค้า
            InventoryManager.Instance.PlayerMoney += 60;
            // Remove item from inventory
            InventoryManager.Instance.RemoveItem(inventoryLocation, itemCode);
        }
    }

    public void SellButton8()
    {
        int itemCode = 10042;  // กำหนดค่า itemCode ที่ต้องการที่จะเอาออก
        InventoryLocation inventoryLocation = InventoryLocation.player;  // กำหนดตำแหน่งของ inventory ที่ต้องการเช็ค

        int itemPosition = InventoryManager.Instance.FindItemInInventory(inventoryLocation, itemCode);  // ใช้คำสั่ง FindItemInInventory เพื่อเช็คว่า itemCode นี้มีใน inventory หรือไม่

        if (itemPosition != -1)
        {
            //กำหนดขายของในร้านค้า
            InventoryManager.Instance.PlayerMoney += 10;
            // Remove item from inventory
            InventoryManager.Instance.RemoveItem(inventoryLocation, itemCode);
        }
    }

    public void SellButton9()
    {
        int itemCode = 10045;  // กำหนดค่า itemCode ที่ต้องการที่จะเอาออก
        InventoryLocation inventoryLocation = InventoryLocation.player;  // กำหนดตำแหน่งของ inventory ที่ต้องการเช็ค

        int itemPosition = InventoryManager.Instance.FindItemInInventory(inventoryLocation, itemCode);  // ใช้คำสั่ง FindItemInInventory เพื่อเช็คว่า itemCode นี้มีใน inventory หรือไม่

        if (itemPosition != -1)
        {
            //กำหนดขายของในร้านค้า
            InventoryManager.Instance.PlayerMoney += 10;
            // Remove item from inventory
            InventoryManager.Instance.RemoveItem(inventoryLocation, itemCode);
        }
    }

    private void CreateItemButton(Sprite itemSprite, string itemName, int itemCost, int positionIndex)
    {
        Transform shopItemTransform = Instantiate(shopItemTemplate, container);
        shopItemTransform.gameObject.SetActive(true);
        RectTransform shopItemRectTransform = shopItemTransform.GetComponent<RectTransform>();

        float shopItemHeight = 90f;
        shopItemRectTransform.anchoredPosition = new Vector2(0, -shopItemHeight * positionIndex);

        shopItemTransform.Find("nameText").GetComponent<TextMeshProUGUI>().SetText(itemName);
        shopItemTransform.Find("costText").GetComponent<TextMeshProUGUI>().SetText(itemCost.ToString());

        shopItemTransform.Find("itemImage").GetComponent<Image>().sprite = itemSprite;
    }
}
