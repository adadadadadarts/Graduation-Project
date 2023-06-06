using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Outliner : MonoBehaviour
{
    public Material defaultMaterial; // Objelerin varsayılan materyali
    public Material outlineMaterial; // Outline materyali

    private Renderer objectRenderer; // Objeyi rendere etmek için kullanılan bileşen

    private bool isOn;

    private void Start()
    {
        objectRenderer = GetComponent<Renderer>(); // Renderer bileşenini al
        objectRenderer.material = defaultMaterial; // Objeye varsayılan materyali uygula
    }

    private void OnMouseEnter()
    {
        isOn = true;
        objectRenderer.material = outlineMaterial; // Objeye outline materyalini uygula
        
    }

    private void OnMouseExit()
    {
        isOn = false;
        objectRenderer.material = defaultMaterial; // Objeye varsayılan materyali uygula
    }
    
    
}
