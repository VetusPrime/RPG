using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseItem
{

    private string itemName;
    private string itemDescription;

    private short itemID;
    private int itemValue;

    private int staminaUsed;
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
    public short ItemID
    {
        get { return itemID; }
        set { itemID = value; }
    }
    public int ItemValue
    {
        get { return itemValue; }
        set { itemValue = value; }
    }
    public int StaminaUsed
    {
        get { return staminaUsed; }
        set { staminaUsed = value; }
    }
    public ItemType itemType
    {
        get { return itemtype; }
        set { itemType = value; }
    }
}