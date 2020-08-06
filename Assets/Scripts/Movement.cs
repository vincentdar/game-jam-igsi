using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float moveSpeed;
    private Rigidbody box;
    public float jumpforce;
    public float height;
    // Start is called before the first frame update
    void Start()
    {
        jumpforce = 10f;
        moveSpeed = 10f;
        box = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            transform.position = new Vector3(transform.position.x,transform.position.y,transform.position.z + 10);
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            transform.position = new Vector3(transform.position.x,transform.position.y,transform.position.z - 10);
        }
        if(Input.GetKeyDown(KeyCode.A))
        {
            transform.position = new Vector3(transform.position.x - 10,transform.position.y,transform.position.z);
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            transform.position = new Vector3(transform.position.x + 10,transform.position.y,transform.position.z);
        }
        /*if(Input.GetKeyDown(KeyCode.Space))
        {
            box.velocity = Vector3.zero;
            box.AddForce(new Vector3(0,10f,0), ForceMode.Impulse);       
        } */
        height = transform.position.y;
    }
    public Vector3 GetPosition()
    {
        return transform.position;
    }
}
