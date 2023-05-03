using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class BeginnerLeader : MonoBehaviour
{
    public GameObject[] objects; // sahnedeki tüm gameobjectleri içeren bir dizi

    public Transform spawnpoint1;
    public Transform spawnpoint2;
    public Transform spawnpoint3;

    public Transform spawnpointlast;

    public List<GameObject> beginnerLeaders;

    public GameObject selectedBeginnerLeader;

    public GameObject beginningMenu;
    
    void Start()
    {
        beginningMenu.SetActive(true);

        // Rastgele iki gameobject seç
        int randomIndex1 = Random.Range(0, objects.Length);
        int randomIndex2 = Random.Range(0, objects.Length);
        int randomIndex3 = Random.Range(0, objects.Length);
        
        
        while (randomIndex2 == randomIndex1 || randomIndex2 == randomIndex3 || randomIndex1 == randomIndex3 ) // Aynı gameobject seçilmesini engellemek için
        {
            if (randomIndex2 == randomIndex1)
            {
                randomIndex2 = Random.Range(0, objects.Length);
            }else if (randomIndex2 == randomIndex3)
            {
                randomIndex3 = Random.Range(0, objects.Length);
            }else if (randomIndex1 == randomIndex3)
            {
                randomIndex3 = Random.Range(0, objects.Length);
            }
            
        }

        //liste at objeleri
        
        beginnerLeaders.Add(Instantiate(objects[randomIndex1], spawnpoint1.position, Quaternion.identity));
        beginnerLeaders.Add(Instantiate(objects[randomIndex2], spawnpoint2.position, Quaternion.identity));
        beginnerLeaders.Add(Instantiate(objects[randomIndex3], spawnpoint3.position, Quaternion.identity));
    }

    public void Choose(int number)
    {
        //sayı dısındakileri destroyle
        for (int i = 0; i < beginnerLeaders.Count; i++)
        {
            if (i == number)
            {
                selectedBeginnerLeader = beginnerLeaders[i];
                selectedBeginnerLeader.GetComponent<JuicyEffect>().originalPosition = spawnpointlast.position;
            }
            else
            {
                Destroy(beginnerLeaders[i]);
            }
        }
        
    }

    public void Update()
    {
        
    }
}
