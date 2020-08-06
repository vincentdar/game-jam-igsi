using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject groundReference;
    public Vector2Int currentPlayerPosition { get; private set; }

    private GroundGrid grid;

    [SerializeField]
    GameObject mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        if (groundReference == null) {
            Debug.LogError("Ground reference NOT SET!");
        }

        grid = groundReference.GetComponent<GroundGrid>();
        GroundNode nodeStart = grid.GetStartingNode();
        currentPlayerPosition = nodeStart.gridPosition;
        transform.position = new Vector3(nodeStart.worldPosition.x, 10, nodeStart.worldPosition.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (mainCamera.GetComponent<CameraController>().isFreeCamera) {
            return;
        }

        if (Input.GetKeyDown(KeyCode.W)) { 
            if (grid.CheckNodeAvailability(currentPlayerPosition.x, currentPlayerPosition.y + 1)) {
                Move(new Vector2Int(currentPlayerPosition.x, currentPlayerPosition.y + 1));
            }
        }
        else if (Input.GetKeyDown(KeyCode.A)) { 
            if (grid.CheckNodeAvailability(currentPlayerPosition.x - 1, currentPlayerPosition.y)) {
                Move(new Vector2Int(currentPlayerPosition.x - 1, currentPlayerPosition.y));
            }
        }
        else if (Input.GetKeyDown(KeyCode.S)) { 
            if (grid.CheckNodeAvailability(currentPlayerPosition.x, currentPlayerPosition.y - 1)) {
                Move(new Vector2Int(currentPlayerPosition.x, currentPlayerPosition.y - 1));
            }
        }
        else if (Input.GetKeyDown(KeyCode.D)) { 
            if (grid.CheckNodeAvailability(currentPlayerPosition.x + 1, currentPlayerPosition.y)) {
                Move(new Vector2Int(currentPlayerPosition.x + 1, currentPlayerPosition.y));
            }
        }
    }

    void Move(Vector2Int newGridPosition)
    {
        Vector3 newGridWorldPosition = grid.nodes[newGridPosition.y, newGridPosition.x].worldPosition;
        transform.position = new Vector3(newGridWorldPosition.x, transform.position.y, newGridWorldPosition.z);
        currentPlayerPosition = newGridPosition;
        print(currentPlayerPosition.x + " " + currentPlayerPosition.y);
    }
}
