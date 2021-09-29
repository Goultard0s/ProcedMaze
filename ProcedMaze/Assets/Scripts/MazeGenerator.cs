using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class MazeGenerator : MonoBehaviour
{
    [Flags]
    public enum Cell
    {
        isVisited = 32,
        wallNorth = 1,
        wallWest = 2,
        wallSouth = 4,
        wallEst = 8
    }

    int gridX = 10;
    int gridY = 10;

    Vector2 currentCell;

    // Start is called before the first frame update
    void Start()
    {
        Cell[,] grid = new Cell[gridX  , gridY];
        currentCell = new Vector2(0.0f,0.0f);
    }

    /*public void FullWalls(Cell[,] grid)
    {
        for(int i = 0; i < gridX; i++)
        {
            for(int j = 0; j < gridY; j++)
            {
                
            }
        }
    }*/
     
    public void CheckBorders(Cell[,] grid)
    {
        //NORTH
        if (grid[(int)currentCell.x, (int)currentCell.y + 1].HasFlag(Cell.wallSouth))
        {
            
        }
        if(grid(int)currentCell.x, (int)currentCell.y - 1.HasFlag)
    }

    public void Backtracking(Cell[,] currentCell)
    {
       


    }


    
   
} 
