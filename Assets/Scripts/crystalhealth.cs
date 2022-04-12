using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crystalhealth : MonoBehaviour
{
    private Rigidbody rb;
   
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();

    }
   

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("myship"))
        {
            myhealth.instance.healthincrease();
            myhealth.instance.staminaincrease();
            MyPooler.ObjectPooler.Instance.ReturnToPool("crystal", this.gameObject);
        }
    }
    

}
