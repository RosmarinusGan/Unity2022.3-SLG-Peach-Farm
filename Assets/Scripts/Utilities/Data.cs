using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemDetails
{
    public int itemID;
    public string itemName;
    public ItemType ItemType;
    public Sprite itemIcon, itemOnWorldSprite;
    public int itemWorkRange;

    public bool canPickedup;
    public bool canDropped;
    public bool canCarried;

    public int itemPrice;
    [Range(0, 1)]
    public float itemSellPercentage;
}
