using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginnerCrew : MonoBehaviour
{
    public GameObject[] objects; // sahnedeki tüm gameobjectleri içeren bir dizi

    public Transform spawnpoint2;
    public Transform spawnpoint3;
    void Start()
    {
        // Rastgele iki gameobject seç
        int randomIndex1 = Random.Range(0, objects.Length);
        int randomIndex2 = Random.Range(0, objects.Length);
        while (randomIndex2 == randomIndex1) // Aynı gameobject seçilmesini engellemek için
        {
            randomIndex2 = Random.Range(0, objects.Length);
        }
    
        Instantiate(objects[randomIndex1], spawnpoint2.position, Quaternion.identity);
        Instantiate(objects[randomIndex2], spawnpoint3.position, Quaternion.identity);
    }
    
}
