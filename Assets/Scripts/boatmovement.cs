using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boatmovement : MonoBehaviour
{
    public float speed=100f;
    public float turnspeed;
    public float nonMotionturnspeed = 80f;
    //1400-280-68

    private Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        
    }
    
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        rb.AddForce(v * speed * this.transform.forward * Time.deltaTime);
        if (v >= 0)
        {
            if (rb.velocity.x == 0f && rb.velocity.z == 0f)
            {
                rb.AddTorque(0f, h * nonMotionturnspeed * Time.deltaTime, 0f);
            }
            else
            {
                rb.AddTorque(0f, h * turnspeed * Time.deltaTime, 0f);
            }
        }
        else {
            if (rb.velocity.x == 0f && rb.velocity.z == 0f)
            {
                rb.AddTorque(0f, -h * nonMotionturnspeed * Time.deltaTime, 0f);
            }
            else
            {
                rb.AddTorque(0f, -h * turnspeed * Time.deltaTime, 0f);
            }



        }





    }
    

}
