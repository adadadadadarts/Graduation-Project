using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginnerCrew : MonoBehaviour
{
    
    public GameObject spritePrefab;
    public Vector3 spawnPosition;

    void SpawnSprite() {
        string[] spriteNames = GetSpriteNames();
        int randomIndex = Random.Range(0, spriteNames.Length);
        string randomSpriteName = spriteNames[randomIndex];
        Sprite randomSprite = Resources.Load<Sprite>("UI/" + randomSpriteName);

        GameObject newSprite = Instantiate(spritePrefab, spawnPosition, Quaternion.identity);
        newSprite.GetComponent<SpriteRenderer>().sprite = randomSprite;
        newSprite.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }

    string[] GetSpriteNames() {
        List<string> spriteNames = new List<string>();
        Object[] sprites = Resources.LoadAll("Characters", typeof(Sprite));

        foreach (Object sprite in sprites) {
            spriteNames.Add(sprite.name);
        }

        return spriteNames.ToArray();
    }
    
}
