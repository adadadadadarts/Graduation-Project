using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginnerLeader : MonoBehaviour
{
    public GameObject[] objects; // sahnedeki tüm gameobjectleri içeren bir dizi

    void Start()
    {
        int randomIndex1 = Random.Range(0, objects.Length);

        // Seçilen gameobjectleri aktif hale getir
        objects[randomIndex1].SetActive(true);
        
    }
}
