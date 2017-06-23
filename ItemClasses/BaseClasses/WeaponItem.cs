using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponItem : BaseItem {

    private int weaponDamage;

    public enum WeaponType
    {
        LONGSWORD,
        BROADSWORD,
        STAFF,
        WAND,
        RAPIER
    }
    private WeaponType weapontype;
    public WeaponType weaponType
    {
        get { return weapontype; }
        set { weapontype = value; }
    }
    public int WeaponDamage
    {
        get { return weaponDamage; }
        set { weaponDamage = value; }
    }
}
