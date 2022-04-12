using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topcameraMovement : MonoBehaviour
{

    
    public float speedH = 3.3f;
    public float speedV = 3.3f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    void Update()
    {
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }

}
