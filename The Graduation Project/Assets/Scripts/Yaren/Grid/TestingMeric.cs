using System.Collections;
using System.Collections.Generic;
using CodeMonkey.Utils;
using UnityEngine;

public class TestingMeric : MonoBehaviour
{
    public GameObject treePrefab;
    public GameObject rockPrefab;
    public GameObject wellPrefab;
    public GameObject minePrefab;

    private Grid<bool> grid;

    void Start()
    {
        
        //min 12x12 bir grid oluşturabilirsin içinde 1 ağaç 1 göl 1 magara ve 1 kaya olcak.
        grid = new Grid<bool>(132, 70, 1f, new Vector3(0, 0, 0), treePrefab, wellPrefab, minePrefab, rockPrefab);
    }

    private void Update()
    {
        //Gridde bir kareye basıldığında ne yapılacak
        if (Input.GetMouseButtonDown(0))
        {
            //grid.SetValue(UtilsClass.GetMouseWorldPosition(), true);
        }

        if (Input.GetMouseButtonDown(1))
        {
            //Debug.Log(grid.GetValue(UtilsClass.GetMouseWorldPosition()));
        }
    }
}
