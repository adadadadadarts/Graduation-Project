using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Outliner : MonoBehaviour
{
    public Material defaultMaterial; // Objelerin varsayılan materyali
    public Material outlineMaterial; // Outline materyali

    public GameObject gameObjectX;// Görünür yapılacak GameObjectx objesi

    private Renderer objectRenderer; // Objeyi rendere etmek için kullanılan bileşen
    
    private void Start()
    {
        objectRenderer = GetComponent<Renderer>(); // Renderer bileşenini al
        objectRenderer.material = defaultMaterial; // Objeye varsayılan materyali uygula
    }

    private void OnMouseEnter()
    {
        objectRenderer.material = outlineMaterial; // Objeye outline materyalini uygula
        
        //fare crew'in üzerine geldiğinde
        if (gameObject.CompareTag("Crew"))
        {
            Vector3 newPosition = transform.position + new Vector3(10f, 10f, 0f);
            gameObjectX.transform.position = newPosition;
            gameObjectX.SetActive(true);
        }
        
        //fare obstacle'in üzerine geldiğinde
        else if (gameObject.CompareTag("Obstacle"))
        {
            Vector3 newPosition = transform.position + new Vector3(5f, 5f, 0f);
            gameObjectX.transform.position = newPosition;
            gameObjectX.SetActive(true);
        }
    }

    private void OnMouseExit()
    {
        objectRenderer.material = defaultMaterial; // Objeye varsayılan materyali uygula
        
        //fare crew'in üzerinden çıktığında
        if (gameObject.CompareTag("Crew"))
        {
            gameObjectX.SetActive(false);
        }
        
        //fare obstacle'in üzerinden çıktığında
        if (gameObject.CompareTag("Obstacle"))
        {
            gameObjectX.SetActive(false);
        }
    }

    private void OnMouseDown()
    {
        //Fare building'e tıkladığında
        if (gameObject.CompareTag("Building"))
        {
            gameObjectX.SetActive(true);
        }
        
        //Fare obstacle'e tıkladığında
        if (gameObject.CompareTag("Obstacle"))
        {
            gameObjectX.SetActive(true);
        }
        
        //Fare player'e tıkladığında
        if (gameObject.CompareTag("Player"))
        {
            gameObjectX.SetActive(true);
        }
    }
    
}