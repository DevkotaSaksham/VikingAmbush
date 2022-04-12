using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausemenu : MonoBehaviour
{
    public static bool ispaused =false;
    public GameObject pausemenuobject;
    public AudioSource enemmyBG;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (ispaused)
            {
                resume();
            }
            else
            {
                pause();
            }
        }
    }
    public void pause() 
    {
        ispaused = true;
        enemmyBG.Pause();
        Time.timeScale = 0f;
        pausemenuobject.SetActive(true);
        
    }
    public void resume()
    {
        enemmyBG.Play();
        ispaused = false;
        Time.timeScale = 1f;
        pausemenuobject.SetActive(false);
    }
    public void quitbtn()
    {
        Application.Quit();

    }
}
