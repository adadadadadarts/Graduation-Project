using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This represents a single ode in our pathfiinding grid

public class PathNode : MonoBehaviour
{
    private Grid<PathNode> grid;
    private int x, y;
    
    public int gCost;
    public int hCost;
    public int fCost;

    public PathNode cameFromNode;
    
    public PathNode(Grid<PathNode> grid, int x, int y)
    {
        this.grid = grid;
        this.x = x;
        this.y = y;
        
    }

    public override string ToString()
    {
        return x + "," + y;
    }
}
