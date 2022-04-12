using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class switerMODE : MonoBehaviour
{
    public static switerMODE instance;
    public Camera followcamera;
    public Camera topcamera;
    public Camera rCanonCamera;

    public Transform topcamPosition;

    private boatmovement boatmove;
    private moveboatsideways sidewaysmovement;
    private GameObject ship;
    private canonshooter canonshootscript;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        ship = GameObject.Find("Ship");
        canonshootscript = ship.GetComponentInChildren<canonshooter>();
        boatmove = ship.GetComponent<boatmovement>();
        sidewaysmovement = ship.GetComponent<moveboatsideways>();
        followcamera.enabled=true;
        topcamera.enabled = false;
        rCanonCamera.enabled = false;
    }

   
    void Update()
    {
        

        if (Input.GetKeyDown("1")) {
            followcamera.enabled = true;
            topcamera.enabled = false;
            boatmove.enabled = true;
            canonshootscript.enabled = false;
            sidewaysmovement.enabled = false;


        }

        if (Input.GetKeyDown("2"))
        {
            followcamera.enabled = false;
            topcamera.enabled = true;
            boatmove.enabled = false;
            topcamera.transform.position =topcamPosition.position;
            sidewaysmovement.enabled = false;
            canonshootscript.enabled = false;

        }

        if (Input.GetKeyDown("e"))
        {
            canonshootscript.enabled = true; ;
            rCanonCamera.enabled = true;
            followcamera.enabled = false;
            topcamera.enabled = false;
            boatmove.enabled = false;
            sidewaysmovement.enabled = true;

        }

    }
    public void restart()
    {
        StartCoroutine(loadscene());

    }
    IEnumerator loadscene()
    {
        yield return new WaitForSeconds(5.5f);
        SceneManager.LoadScene(0);
    }
}
