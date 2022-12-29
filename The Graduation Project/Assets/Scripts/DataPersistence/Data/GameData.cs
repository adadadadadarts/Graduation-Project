using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class GameData 
{
    public int deathCount;
    public Vector3 playerPosition;
    public SerializableDictionary<string, bool> coinsCollected;
    //bu constructorda tanimlanan degerler varsayilan degerler olacaktir.
    //oyun, yuklenecek veri olmadiginda baslar.
    public GameData()
    {
        this.deathCount = 0;
        playerPosition = Vector3.zero;
        coinsCollected = new SerializableDictionary<string, bool>();
    }
}
