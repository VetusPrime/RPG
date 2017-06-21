using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacterClass{

    private string characterClassName;

    private string characterClassDescription;

    private int force;                     //Strength, how hard you hit and can be hit
    private int coordination;              //Dexterity, how well you can hit, use items, etc.
    private int judgement;                 //Intelligence, how you know when to hit and where, general intelligence

    public string CharacterClassName
    {
        get { return characterClassName; }
        set { characterClassName = value; }
    }
    public string CharacterClassDescription
    {
        get { return characterClassDescription; }
        set { characterClassDescription = value; }
    }
    public int Force
    {
        get { return force; }
        set { force = value; }
    }
    public int Coordination
    {
        get { return coordination; }
        set { coordination = value; }
    }
    public int Judgement
    {
        get { return judgement; }
        set { judgement = value; }
    }
}
