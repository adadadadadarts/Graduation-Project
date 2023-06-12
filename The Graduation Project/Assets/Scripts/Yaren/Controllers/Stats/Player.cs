using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new Player", menuName = "Player")]
public class Player : ScriptableObject
{
    public string playerName;
    public Sprite playerArtwork;
    
    
    public bool isLeader = false;

    public Dictionary<int, string> currentBuffs;
    public Dictionary<int, string> currentDebuffs;

    public int maxHp = 100;
    public int currentHp = 100;
    public int hpBuff = 1;
    public int hpDebuff = 1;

    public int maxSt = 100;
    public int currentSt = 100;
    public int stBuff = 1;
    public int stDebuff = 1;

    public int maxHg = 100;
    public int currentHg = 100;
    public int hgBuff = 1;
    public int hgDebuff = 1;

    public int maxTh = 100;
    public int currentTh = 100;
    public int thBuff = 1;
    public int thDebuff = 1;

    public int maxStr = 100;
    public int currentStr = 100;
    public int strBuff = 1;
    public int strDebuff = 1;

    public int speed = 15;
    public int speedBuff = 1;
    public int speedDebuff = 1;

    public int aSpeed = 1;
    public int aSpeedBuff = 1;
    public int aSpeedDebuff = 1;
}

