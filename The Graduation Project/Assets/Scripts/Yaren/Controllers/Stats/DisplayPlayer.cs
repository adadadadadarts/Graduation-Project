using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class DisplayPlayer : MonoBehaviour
{
    public Player player;
    
    //Player Attachments
    public TMP_Text playerNameText;
    public GameObject playerMiniImage;
    public TMP_Text hpText;
    public TMP_Text hgText;
    public TMP_Text thText;
    public TMP_Text stText;
    public TMP_Text strText;
    public TMP_Text speedText;
    public TMP_Text aSpeedText;

    /*LaterWork
    leadershipText;
    cJobText;
    */

    void Start()
    {
        playerNameText.SetText(player.playerName);
        playerMiniImage.GetComponent<SpriteRenderer>().sprite = player.playerArtwork;
        hpText.SetText("Health : " + player.currentHp.ToString());
        hgText.SetText("Hungerness : " + player.currentHg.ToString());
        thText.SetText("Thirstiness : " + player.currentTh.ToString());
        stText.SetText("Stamina : " + player.currentSt.ToString());
        strText.SetText("Strength : " + player.currentStr.ToString());
        speedText.SetText("Move Speed : " + player.speed.ToString());
        aSpeedText.SetText("Attack Speed : " + player.aSpeed.ToString());
    }

}
