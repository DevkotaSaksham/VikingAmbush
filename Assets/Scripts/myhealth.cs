using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class myhealth : MonoBehaviour
{
    public static myhealth instance;
    public float health = 100;
    public float stamina = 0;

    public Camera endcamera;
    public GameObject endscreen;
    public GameObject powerupicon;

    public AudioSource deathsound;

    public AudioSource powerup;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        endcamera.enabled = false;
        powerupicon.SetActive(false);
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag.Equals("enemyball"))
        {
            health -= 10;
            healthbarscript.instance.decreseit((int)health);

        }
    }
    public void staminaincrease()
    {
        if (stamina < 30)
        {

            stamina += 10;
        }

    }
    public void healthincrease()
    {
        if (health < 100)
        {
            if ((health + 30) > 100)
            {
                health = 100;
            }
            else
            {
                health += 30;
            }

        }

        healthbarscript.instance.increaseit((int)health);
    }


    void Update()
    {
        if (health < 1)
        {
            switerMODE.instance.restart();
            endcamera.enabled = true;
            deathsound.Play();
            endscreen.SetActive(true);
            this.gameObject.SetActive(false);
        }
        if (stamina >= 30)
        {
            powerupicon.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Return))
            {
                
                stamina = 0;
                powerupicon.SetActive(false);

                Collider[] colliders = Physics.OverlapSphere(this.gameObject.transform.position, 150);
                foreach (Collider solocollider in colliders)
                {
                    if (solocollider.gameObject.tag.Equals("enemy"))
                    {

                        enemyHealth enemy = solocollider.gameObject.GetComponent<enemyHealth>();
                        StartCoroutine(powermove(enemy));
                       
                        
                    }

                }
            }
        }



    }
    IEnumerator powermove(enemyHealth enemy)
    {
        powerup.Play();
        yield return new WaitForSeconds(4.5f);
        enemy.decreaseenemyhealth(50);

    }


}
