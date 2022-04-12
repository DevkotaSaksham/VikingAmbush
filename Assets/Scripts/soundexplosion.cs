using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundexplosion : MonoBehaviour
{
    public static soundexplosion instance;

    public AudioSource explosionsound;

    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    public void playexplosion()
    {
        explosionsound.Play();
    }
}
