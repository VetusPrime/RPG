using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmorItem : BaseItem {

    private int armorProtection;

    public enum ArmorType
    {
        HEAD,
        SHOULDERS,
        HANDS,
        TORSO,
        LEGS,
        FEET
    }
    private ArmorType armortype;
    public ArmorType armorType
    {
        get { return armortype; }
        set { armortype = value; }
    }
    public int ArmorProtection
    {
        get { return armorProtection; }
        set { armorProtection = value; }
    }
}
