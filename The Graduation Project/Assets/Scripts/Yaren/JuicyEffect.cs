using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JuicyEffect : MonoBehaviour
{
    public float verticalOffset = 0.1f; // Kaç birim yukarı-aşağı hareket edeceği
    
    public Vector3 originalPosition;
    
    

    private void Start()
    {
        // Sprite'ın orijinal pozisyonunu kaydediyoruz
        originalPosition = transform.position;
    }

    /*
    private void Update()
    {
        originalPosition = transform.position;
        // Sprite'ı verticalOffset birim yukarı ve aşağı hareket ettiriyoruz
        transform.position = new Vector3(originalPosition.x, originalPosition.y + Mathf.Sin(Time.time * 5) * verticalOffset, originalPosition.z);
    }*/
}
