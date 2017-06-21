using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorCharacter : BaseCharacterClass{

    public WarriorCharacter()
    {
        CharacterClassName = "Swordsman";
        CharacterClassDescription = "A Relic from a past time. The art of swordplay is lost and obsolete.";
        Force = Random.Range(7, 15);
        Coordination = Random.Range(7, 15);
        Judgement = 1;
    }
}
