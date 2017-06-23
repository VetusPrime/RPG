using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MageCharacter : BaseCharacterClass {

	public MageCharacter()
    {
        CharacterClassName = "Mage";
        CharacterClassDescription = "The average magic user.";
        Force = Random.Range(5, 10);
        Coordination = Random.Range(5, 10);
        Judgement = Random.Range(7, 15);
        Stamina = 100;
    }
}
