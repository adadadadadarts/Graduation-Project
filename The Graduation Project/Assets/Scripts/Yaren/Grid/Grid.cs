using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using CodeMonkey.Utils;

public class Grid<TGridObject> : MonoBehaviour
{
    public event EventHandler<OnGridValueChangedEventArgs> OnGridValueChanged;
    public class OnGridValueChangedEventArgs : EventArgs {
        public int x;
        public int y;
        
    }
    
    private int width, height;
    private float cellSize;
    private Vector3 originPosition;
    private TGridObject[,] gridArray;
    private TextMesh[,] debugTextArray; //multi-dimensional array with 2 dimensions
    
    // Width and height of the tree object in cells
    private int treeWidth = 2;
    private int treeHeight = 3;

    // Width and height of the well object in cells
    private int wellWidth = 3;
    private int wellHeight = 2;

    // Width and height of the rock object in cells
    private int rockWidth = 2;
    private int rockHeight = 1;

    // Width and height of the mine object in cells
    private int mineWidth = 2;
    private int mineHeight = 2;


    //A constructor that recieves width and height
    public Grid(int width, int height, float cellSize, Vector3 originPosition, GameObject treePrefab, GameObject wellPrefab, GameObject minePrefab, GameObject rockPrefab)
    {
        this.height = height;
        this.width = width;
        this.cellSize = cellSize;
        this.originPosition = originPosition;

        gridArray = new TGridObject[width, height];

        bool showDebug = true;
        if (showDebug)
        {
            debugTextArray = new TextMesh[width, height];
            
            //Text object for grid underline
            for (int i = 0; i < gridArray.GetLength(0); i++)
            {
                for (int j = 0; j < gridArray.GetLength(1); j++)
                {
                    //Draw the inside number and the grid
                    debugTextArray[i, j] = UtilsClass.CreateWorldText( /*gridArray[i, j].ToString()*/ null, null,GetWorldPosition(i, j) + new Vector3(cellSize, cellSize) * .5f, 6 , Color.white, TextAnchor.MiddleCenter );
                
                    /*
                    //Draw the outside lines
                    Debug.DrawLine(GetWorldPosition(i, j), GetWorldPosition(i, j + 1), Color.white, 100f);
                    Debug.DrawLine(GetWorldPosition(i, j), GetWorldPosition(i + 1, j), Color.white, 100f);*/

                }
                /*
                //Draw the end lines
                Debug.DrawLine(GetWorldPosition(0, height), GetWorldPosition(width, height), Color.white, 100f);
                Debug.DrawLine(GetWorldPosition(width, 0), GetWorldPosition(width, height), Color.white, 100f);*/
                
            }
            //spawn obstacle objects
            
            // spawnPoints listesini 3x3 hücre aralıklarında oluştur
            List<Vector3> spawnPoints = new List<Vector3>();
            int spawnPointsX = width / 3;
            int spawnPointsY = height / 3;

            for (int x = 0; x < spawnPointsX; x++)
            {
                for (int y = 0; y < spawnPointsY; y++)
                {
                    Vector3 spawnPoint = GetWorldPosition(x * 3, y * 3) + new Vector3(cellSize, cellSize) * 0.5f;
                    spawnPoints.Add(spawnPoint);
                }
            }

            // Obje sayısına bakılmaksızın objeleri oluştur
            SpawnObjects(treePrefab, spawnPoints, treeWidth, treeHeight, 50);
            SpawnObjects(wellPrefab, spawnPoints, wellWidth, wellHeight, 15);
            SpawnObjects(rockPrefab, spawnPoints, rockWidth, rockHeight, 50);
            SpawnObjects(minePrefab, spawnPoints, mineWidth, mineHeight, 15);
        }
    }
    
    // Obje oluşturma işlemini tek bir metoda taşı
    private void SpawnObjects(GameObject prefab, List<Vector3> spawnPoints, int objectWidth, int objectHeight, int objectCount)
    {
        for (int i = 0; i < objectCount; i++)
        {
            bool isSpawned = false;
            while (!isSpawned && spawnPoints.Count > 0)
            {
                int randomIndex = UnityEngine.Random.Range(0, spawnPoints.Count);
                Vector3 spawnPoint = spawnPoints[randomIndex];
                spawnPoints.RemoveAt(randomIndex);

                Vector3 objectPosition = GetObjectSpawnPosition(prefab, spawnPoint, objectWidth, objectHeight);

                bool isOverlapping = CheckForOverlap(objectPosition, objectWidth, objectHeight);
                bool isInsideCameraBounds = CheckInsideCameraBounds(objectPosition);
                bool isOutsideBeginnerCameraBounds = CheckOutsideBeginnerCameraBounds(objectPosition);

                if (!isOverlapping && isInsideCameraBounds && !isOutsideBeginnerCameraBounds)
                {
                    GameObject objectInstance = Instantiate(prefab, objectPosition, Quaternion.identity);
                    // Gerekli diğer ayarlamaları yap

                    isSpawned = true;
                }
            }
        }
    }
    
    private bool CheckInsideCameraBounds(Vector3 position)
    {
        float xMin = 5f;
        float xMax = 128f;
        float yMin = 0f;
        float yMax = 69f;

        float x = position.x;
        float y = position.y;

        return x >= xMin && x <= xMax && y >= yMin && y <= yMax;
    }
    
    private bool CheckOutsideBeginnerCameraBounds(Vector3 position)
    {
        float xMin = 57f;
        float xMax = 76f;
        float yMin = 30f;
        float yMax = 41f;

        float x = position.x;
        float y = position.y;

        return x >= xMin && x <= xMax && y >= yMin && y <= yMax;
    }

    
    // Method to calculate the object spawn position based on cell and object dimensions
    private Vector3 GetObjectSpawnPosition(GameObject prefab, Vector3 spawnPoint, int objectWidth, int objectHeight)
    {
        float offsetX = (cellSize - prefab.transform.localScale.x) / 2f;
        float offsetY = (cellSize - prefab.transform.localScale.y) / 2f;
        Vector3 objectPosition = GetWorldPosition(Mathf.FloorToInt(spawnPoint.x), Mathf.FloorToInt(spawnPoint.y)) + new Vector3(offsetX, offsetY, 0f);

        float widthOffset = (objectWidth % 2 == 0) ? cellSize / 2f : 0f;
        float heightOffset = (objectHeight % 2 == 0) ? cellSize / 2f : 0f;
        objectPosition += new Vector3(widthOffset, heightOffset, 0f);

        return objectPosition;
    }
    
    // Method to check for overlapping with existing objects
    private bool CheckForOverlap(Vector3 position, int halfWidth, int halfHeight)
    {
        Collider[] colliders = Physics.OverlapBox(position, new Vector3(cellSize * halfWidth, cellSize * halfHeight, 0f));
        return colliders.Length > 0;
    }
    
    public Vector3 GetWorldPosition(int x, int y)
    {
        return new Vector3(x, y) * cellSize + originPosition;
    }

    private void GetXY(Vector3 worldPosition, out int x, out int y)
    {
        x = Mathf.FloorToInt((worldPosition - originPosition).x / cellSize);
        y = Mathf.FloorToInt((worldPosition - originPosition).y / cellSize);
    }

    public void SetValue(int x, int y, TGridObject value)
    {
        if (x >= 0 && y >= 0 && x < width && y < height)
        {
            gridArray[x, y] = value;
            debugTextArray[x, y].text = gridArray[x, y].ToString();
            if (OnGridValueChanged != null)
            {
                OnGridValueChanged(this, new OnGridValueChangedEventArgs { x = x, y = y });
            }
        }
    }

    public void SetValue(Vector3 worldPosition, TGridObject value)
    {
        int x, y;
        GetXY(worldPosition, out x, out y);
        SetValue(x, y, value);
    }

    public TGridObject GetValue(int x, int y)
    {
        if (x >= 0 && y >= 0 && x < width && y < height)
        {
            return gridArray[x, y];
        }
        else
        {
            return default(TGridObject);
        }
    }
    
    public TGridObject GetValue(Vector3 worldPosition)
    {
        int x, y;
        GetXY(worldPosition, out x, out y);
        return GetValue(x, y);
    }
}
