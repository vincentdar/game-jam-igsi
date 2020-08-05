using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundNode
{
    public Vector2Int gridPosition { get; private set; }
    private bool isWalkable;
    public Vector3 worldPosition;

    public GroundNode(int gridX, int gridY, bool isWalkable)   
    {
        this.gridPosition = new Vector2Int(gridX, gridY);
        this.isWalkable = isWalkable;
    }
}
