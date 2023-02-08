using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float cameraSpeed;

    // Start is called before the first frame update
    void Start()
    {
        if (cameraSpeed <= 0)
        {
            cameraSpeed= 14.0f;
            Debug.Log("Speed was set incorrect, deafaulting to " + cameraSpeed.ToString());
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(cameraSpeed * Time.deltaTime, 0, 0);
    }
}
