using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveboatsideways : MonoBehaviour
{
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

    }


    void FixedUpdate()
    {

        float h = Input.GetAxis("Horizontal");

        rb.AddForce(-h * 1100 * this.transform.forward * Time.deltaTime);

    }
}
