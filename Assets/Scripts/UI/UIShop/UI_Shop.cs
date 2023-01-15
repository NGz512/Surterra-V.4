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
        // Add item to inventory
        InventoryManager.Instance.AddItem(InventoryLocation.player, 10000);
    }
    public void BuyButton1()
    {
        // Add item to inventory
        InventoryManager.Instance.AddItem(InventoryLocation.player, 10003);
    }

    public void BuyButton2()
    {
        // Add item to inventory
        InventoryManager.Instance.AddItem(InventoryLocation.player, 10004);
    }

    public void BuyButton3()
    {
        // Add item to inventory
        InventoryManager.Instance.AddItem(InventoryLocation.player, 10005);
    }

    public void BuyButton4()
    {
        // Add item to inventory
        InventoryManager.Instance.AddItem(InventoryLocation.player, 10008);
    }

    public void BuyButton5()
    {
        // Add item to inventory
        InventoryManager.Instance.AddItem(InventoryLocation.player, 10009);
    }

    public void BuyButton6()
    {
        // Add item to inventory
        InventoryManager.Instance.AddItem(InventoryLocation.player, 100012);
    }

    public void BuyButton7()
    {
        // Add item to inventory
        InventoryManager.Instance.AddItem(InventoryLocation.player, 100013);
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
