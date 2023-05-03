using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Spawner : MonoBehaviour
{
    //ELLE GRID-TILEMAP WORLD BUILDING UVUR ZIVIRI YAZILCAK, BU KOD YETERİNCE İŞİMİZİ GÖRMÜYOR. :(
    
    /*
    // Start is called before the first frame update
    public Tilemap treeMap;
    public Tile treeTile;
    public int numberOfTrees;
    

    public Tile rockTile;
    public int numberOfRocks;
    
    public Tile wellTile;
    public int numberOfWells;
    
    public List<TileBase> spawnedTrees;
    public List<TileBase> spawnedRocks;
    public List<TileBase> spawnedWells;

    void Start()
    {
        for (int i = 0; i < numberOfTrees; i++)
        {
            Vector3Int randomPos = new Vector3Int(Random.Range(treeMap.cellBounds.xMin, treeMap.cellBounds.xMax), Random.Range(treeMap.cellBounds.yMin, treeMap.cellBounds.yMax), 0);
            if (treeMap.HasTile(randomPos))
            {
                i--;
                continue;
            }
            treeMap.SetTile(randomPos, treeTile);
            
            
            //OLUSTURDUGUMU BURDA TUTUOM
            spawnedTrees.Add(treeMap.GetTile(randomPos));
        }
        
        for (int i = 0; i < numberOfRocks; i++)
        {
            Vector3Int randomPos = new Vector3Int(Random.Range(treeMap.cellBounds.xMin, treeMap.cellBounds.xMax), Random.Range(treeMap.cellBounds.yMin, treeMap.cellBounds.yMax), 0);
            if (treeMap.HasTile(randomPos))
            {
                i--;
                continue;
            }
            treeMap.SetTile(randomPos, rockTile);
            
            //OLUSTURDUGUMU BURDA TUTUOM
            spawnedRocks.Add(treeMap.GetTile(randomPos));
        }
        
        for (int i = 0; i < numberOfWells; i++)
        {
            Vector3Int randomPos = new Vector3Int(Random.Range(treeMap.cellBounds.xMin, treeMap.cellBounds.xMax), Random.Range(treeMap.cellBounds.yMin, treeMap.cellBounds.yMax), 0);
            if (treeMap.HasTile(randomPos))
            {
                i--;
                continue;
            }
            treeMap.SetTile(randomPos, wellTile);
            
            //OLUSTURDUGUMU BURDA TUTUOM
            spawnedWells.Add(treeMap.GetTile(randomPos));
        }
        
    }*/
}
