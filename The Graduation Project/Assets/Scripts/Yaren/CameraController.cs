using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject camera;

    public void LeftArrow()
    {
        if(camera.transform.position.x > 13) camera.transform.position = new Vector3(camera.transform.position.x - 18, camera.transform.position.y, -10f);
    }
    
    public void RightArrow()
    {
        if(camera.transform.position.x < 121) camera.transform.position = new Vector3(camera.transform.position.x + 18, camera.transform.position.y, -10f);
    }
    
    public void TopArrow()
    {
        if(camera.transform.position.y < 57) camera.transform.position = new Vector3(camera.transform.position.x, camera.transform.position.y + 10, -10f);
    }
    
    public void BottomArrow()
    {
        if(camera.transform.position.y > 6) camera.transform.position = new Vector3(camera.transform.position.x, camera.transform.position.y - 10, -10f);
    }
}
