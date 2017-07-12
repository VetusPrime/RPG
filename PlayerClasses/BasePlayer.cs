using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayer {

    private string playerName;
    private int playerLevel;
    private BaseCharacterClass playerClass;
    private int force;
    private int coordination;
    private int judgement;

    public string PlayerName { get; set; }
    public int PlayerLevel { get; set; }
    public BaseCharacterClass PlayerClass { get; set; }
    public int Force { get; set; }
    public int Coordination { get; set; }
    public int Judgement { get; set; }
}
