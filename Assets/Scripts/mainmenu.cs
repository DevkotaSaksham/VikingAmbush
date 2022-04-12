using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public static bool ispaused = false;
    public GameObject howtoscreen;
    public void loadgame()
    {
        SceneManager.LoadScene(1);
    }
    public void quitgame()
    {
        Application.Quit();
    }
    private void Update()
    {
        if (ispaused)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {

                back();
            }
        }
    }

    public void howto()
    {
        howtoscreen.SetActive(true);
        ispaused = true;
    }
    public void back()
    {
        howtoscreen.SetActive(false);
        ispaused = false;
    }
}

