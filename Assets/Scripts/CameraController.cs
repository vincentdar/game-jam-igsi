using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [Header("Hello World")]

    [SerializeField]
    GameObject player;

    [SerializeField]
    float speed = 3;

    public bool isFreeCamera { get; private set; }

    void Start()
    {
        isFreeCamera = false;
        transform.rotation = Quaternion.Euler(40, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) {
            isFreeCamera = !isFreeCamera;
        }

        if (isFreeCamera) {
            if (Input.GetKey(KeyCode.W)) {
                transform.position += new Vector3(0, 0, speed);
            }
            else if (Input.GetKey(KeyCode.S)) {
                transform.position += new Vector3(0, 0, -speed);
            }
            else if (Input.GetKey(KeyCode.A)) {
                transform.position += new Vector3(-speed, 0, 0);
            }
            else if (Input.GetKey(KeyCode.D)) {
                transform.position += new Vector3(speed, 0, 0);
            }
            
        } else {
            transform.position = Vector3.Lerp(transform.position, new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z - 10), 0.125f);
        }
    }
}
