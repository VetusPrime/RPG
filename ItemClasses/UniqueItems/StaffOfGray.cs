using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaffOfGray : WeaponItem {

    public StaffOfGray()
    {
        weaponType = WeaponType.STAFF;
        ItemName = "Staff of Gray";
        ItemDescription = "A legendary staff that turns white eventually.";
        ItemID = 10000;
        ItemValue = 25000;
        StaminaUsed = 25;
    }
}
