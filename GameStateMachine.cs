using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateMachine : MonoBehaviour {

    public enum GameStates
    {
        TITLE,
        MENU,
        INVENTORY,
        OVERWORLD,
        COMBAT
    }
    private GameStates currentState;

	// Use this for initialization
	void Start () {
        currentState = GameStates.TITLE;
	}
	
	// Update is called once per frame
	void Update () {
        switch (currentState)
        {
            case GameStates.TITLE:

                break;
            case GameStates.MENU:

                break;
            case GameStates.INVENTORY:

                break;
            case GameStates.OVERWORLD:

                break;
            case GameStates.COMBAT:

                break;
        }
	}
}
