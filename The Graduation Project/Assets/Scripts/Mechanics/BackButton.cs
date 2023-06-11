using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour
{
    public GameObject gameObjectX;
    
    public void Back()
    {
        Debug.Log("Hi");
        gameObjectX.SetActive(false);
    }

}
