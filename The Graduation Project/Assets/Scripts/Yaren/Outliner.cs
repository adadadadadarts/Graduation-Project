using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Outliner : MonoBehaviour
{
    public Material defaultMaterial; // Objelerin varsayılan materyali
    public Material outlineMaterial; // Outline materyali

    public GameObject gameObjectX; // Görünür yapılacak GameObjectx objesi

    private Renderer objectRenderer; // Objeyi rendere etmek için kullanılan bileşen

    private bool isOn;

    private void Start()
    {
        objectRenderer = GetComponent<Renderer>(); // Renderer bileşenini al
        objectRenderer.material = defaultMaterial; // Objeye varsayılan materyali uygula
    }

    private void OnMouseEnter()
    {
        objectRenderer.material = outlineMaterial; // Objeye outline materyalini uygula
        isOn = true;
        if (gameObject.CompareTag("Crew"))
        {
            Vector3 newPosition = transform.position + new Vector3(10f, 10f, 0f);
            gameObjectX.transform.position = newPosition;
            gameObjectX.SetActive(true);
        }
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
        isOn = false;
        if (gameObject.CompareTag("Crew"))
        {
            gameObjectX.SetActive(false);
        }
        else if (gameObject.CompareTag("Obstacle"))
        {
            gameObjectX.SetActive(false);
        }
    }

    private void OnMouseDown()
    {
        if (gameObject.CompareTag("Building"))
        {
            gameObjectX.SetActive(true);
        }
    }
    
}