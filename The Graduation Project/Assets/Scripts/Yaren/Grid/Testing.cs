using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;
using UnityEngine.Diagnostics;

public class Testing : MonoBehaviour
{
    public GameObject treePrefab;
    public GameObject rockPrefab;
    public GameObject wellPrefab;
    public GameObject minePrefab;

    private Grid<bool> grid;

    void Start()
    {
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
            Debug.Log(grid.GetValue(UtilsClass.GetMouseWorldPosition()));
        }
    }
}
