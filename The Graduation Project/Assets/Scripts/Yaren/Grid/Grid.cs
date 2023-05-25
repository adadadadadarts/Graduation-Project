using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class Grid : MonoBehaviour
{
    private int width, height;
    private float cellSize;
    private int[,] gridArray; //multi-dimensional array with 2 dimensions
    
    //A constructor that recieves width and height
    public Grid(int width, int height, float cellSize)
    {
        this.height = height;
        this.width = width;
        this.cellSize = cellSize;

        gridArray = new int[width, height];
        
        //Text object for grid underline
        for (int i = 0; i < gridArray.GetLength(0); i++)
        {
            for (int j = 0; j < gridArray.GetLength(1); j++)
            {
                //Draw the inside number and the grid
                UtilsClass.CreateWorldText(gridArray[i, j].ToString(), null,GetWorldPosition(i, j) + new Vector3(cellSize, cellSize) * .5f, 5, Color.white, TextAnchor.MiddleCenter );
                
                //Draw the outside lines
                Debug.DrawLine(GetWorldPosition(i, j), GetWorldPosition(i, j + 1), Color.white, 100f);
                Debug.DrawLine(GetWorldPosition(i, j), GetWorldPosition(i + 1, j), Color.white, 100f);

            }
            
            //Draw the end lines
            Debug.DrawLine(GetWorldPosition(0, height), GetWorldPosition(width, height), Color.white, 100f);
            Debug.DrawLine(GetWorldPosition(width, 0), GetWorldPosition(width, height), Color.white, 100f);
        }

        Vector3 GetWorldPosition(int x, int y)
        {
            return new Vector3(x, y) * cellSize;
        }
    }
}
