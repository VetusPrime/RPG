using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Narsil : WeaponItem {

    public Narsil()
    {
        weaponType = WeaponType.LONGSWORD;
        itemType = ItemType.WEAPON;
        ItemName = "Narsil";
        ItemDescription = "A legendary sword, fixed by elves.";
        ItemID = 10001;
        ItemValue = 25000;
        StaminaUsed = 25;
    }
}
