using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    GroundGrid : Membuat grid pada plane utk mapping movementnya dan juga pathfinding musuh.
*/

public class GroundGrid : MonoBehaviour
{
    // Jumlah grid yang diinginkan (row, col);
    public float gridNodeDiameter = 2;

    public Vector3 gridWorldSize { get; private set; }
    private int gridSizeX, gridSizeY;

    public GroundNode[,] nodes { get; private set; }
    public Vector2 bottomLeftWorldPosition { get; private set; }

    public Vector2Int nodeStartXY;

    void Awake()
    {
        gridWorldSize = GetComponent<MeshCollider>().bounds.size;

        bottomLeftWorldPosition = new Vector2(transform.position.x - gridWorldSize.x / 2 + gridNodeDiameter / 2, transform.position.z - gridWorldSize.z / 2);

        print(bottomLeftWorldPosition);

        gridSizeX = Mathf.RoundToInt(gridWorldSize.x / gridNodeDiameter);
        gridSizeY = Mathf.RoundToInt(gridWorldSize.z / gridNodeDiameter);

        CreateGrid();
    }

    void CreateGrid() 
    {
        nodes = new GroundNode[gridSizeY, gridSizeX];

        bottomLeftWorldPosition = new Vector2(
            transform.position.x - gridWorldSize.x / 2 + gridNodeDiameter / 2, 
            transform.position.z - gridWorldSize.z / 2 + gridNodeDiameter / 2);

        for (int i = 0; i < gridSizeY; i++) {
            for (int j = 0; j < gridSizeX; j++) {
                Vector3 worldPosition = new Vector3();
                worldPosition.x = bottomLeftWorldPosition.x + (j * gridNodeDiameter);
                worldPosition.z = bottomLeftWorldPosition.y + (i * gridNodeDiameter);
                worldPosition.y = 0;
                nodes[i, j] = new GroundNode(j, i, true);
                nodes[i, j].worldPosition = worldPosition;
            }
        }

        print("Grid created!");
    }

    // Untuk debugging.
    void OnDrawGizmos() 
    {
        gridWorldSize = GetComponent<MeshCollider>().bounds.size;
        Gizmos.DrawWireCube(transform.position, new Vector3(gridWorldSize.x, 0, gridWorldSize.z));

        bottomLeftWorldPosition = new Vector2(transform.position.x - gridWorldSize.x / 2, transform.position.z - gridWorldSize.z / 2);

        if (nodes != null) 
        {
            foreach (GroundNode node in nodes) {
                Gizmos.color = Color.blue;
                Gizmos.DrawWireCube(node.worldPosition, Vector3.one * gridNodeDiameter);
            }
        }
    }


    void Update()
    {
        
    }

    public GroundNode GetStartingNode() 
    {
        print("Hey");
        return nodes[0, 0];
    }

    public bool CheckNodeAvailability(int x, int y) {
        return (x >= 0 && x < gridSizeX && y >= 0 && y < gridSizeY);
    }
}
