using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatStateMachine : MonoBehaviour {

    public enum CombatStates
    {
        START,
        PLAYERCHOICE,
        ENEMYCHOICE,
        LOSE,
        WIN
    }
    private CombatStates currentState;
	// Use this for initialization
	void Start () {
        currentState = CombatStates.START;
	}
	
	// Update is called once per frame
	void Update () {
        switch(currentState){
            case CombatStates.START:
                Debug.Log("Start State");
                break;
            case CombatStates.PLAYERCHOICE:

                break;
            case CombatStates.ENEMYCHOICE:

                break;
            case CombatStates.LOSE:

                break;
            case CombatStates.WIN:

                break;
            default:
                Debug.Log("Error: Invalid CombatState");
                break;
        }
	}
}
