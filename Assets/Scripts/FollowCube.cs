using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCube : MonoBehaviour
{
    public Movement cube;
    private Vector3 camerapos;
    // Start is called before the first frame update
    void Start()
    {
        camerapos = transform.position - cube.GetPosition();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(transform.position.x + cube.GetPosition().x + camerapos.x, transform.position.y + cube.GetPosition().y + camerapos.y,transform.position.z + cube.GetPosition().z + camerapos.z);
        transform.position = new Vector3(cube.GetPosition().x + camerapos.x ,cube.GetPosition().y + camerapos.y,cube.GetPosition().z + camerapos.z);
    }
}
