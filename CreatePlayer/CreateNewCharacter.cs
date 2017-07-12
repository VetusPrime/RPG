using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewCharacter : MonoBehaviour {

    private BasePlayer newPlayer;
	// Use this for initialization
	void Start () {
        newPlayer = new BasePlayer();
        newPlayer.PlayerClass = new WarriorCharacter();
        newPlayer.PlayerLevel = 1;
        newPlayer.PlayerName = "Cloudstrider";
        newPlayer.Force = newPlayer.PlayerClass.Force;
        newPlayer.Coordination = newPlayer.PlayerClass.Coordination;
        newPlayer.Judgement = newPlayer.PlayerClass.Judgement;
    }

    // Update is called once per frame
    void Update() {

    }
}
