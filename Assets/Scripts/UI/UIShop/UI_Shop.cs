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
