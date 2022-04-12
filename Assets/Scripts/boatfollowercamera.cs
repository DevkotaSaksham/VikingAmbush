using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boatfollowercamera : MonoBehaviour
{
    public Transform followercamPosition;
    

    
    void LateUpdate()
    {
        Vector3 targetpos = followercamPosition.transform.position;
         Vector3 smoothed= Vector3.Lerp(transform.position, targetpos, 0.2f);
        transform.position = smoothed;
    }
}
