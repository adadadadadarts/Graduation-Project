using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Sayac : MonoBehaviour
{
    public TextMeshProUGUI sayacText;
    public int sayac;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update(){
        
        
    }

    public void ClickButton()
    {
        sayac++;
        sayacText.text = sayac.ToString();
        
    }
}

