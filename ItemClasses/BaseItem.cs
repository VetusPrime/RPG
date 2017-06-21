using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseItem
{

    private string itemName;
    private string itemDescription;

    private int itemID;
    private int itemValue;

    public enum ItemType
    {
        WEAPON,
        ARMOR,
        FOOD,
        POTION,
        MISC
    }
    private ItemType itemtype;

    public string ItemName
    {
        get { return itemName; }
        set { itemName = value; }

    }
    public string ItemDescription
    {
        get { return itemDescription; }
        set { itemDescription = value; }
    }
    public int ItemID
    {
        get { return itemID; }
        set { itemID = value; }
    }
    public int ItemValue
    {
        get { return itemValue; }
        set { itemValue = value; }
    }
}