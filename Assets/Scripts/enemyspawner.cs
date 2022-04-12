using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawner : MonoBehaviour
{
    private float timer = 4f;
    public GameObject enemyprefab;
    private GameObject ship;
    public GameObject magicring1;
    //public GameObject magicring2;
    private ParticleSystem appearparticle;
    public static enemyspawner instance;

    
    public AudioSource enemyentry;
    private void Start()
    {
        appearparticle = magicring1.GetComponent<ParticleSystem>();
        ship = GameObject.FindGameObjectWithTag("myship");
        magicring1.SetActive(false);
    }
    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        if (appearparticle.isStopped)
        {
            magicring1.SetActive(false);
        }
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            int activenum = GameObject.FindGameObjectsWithTag("enemy").Length;
            if (activenum <= 2)
            {
                StartCoroutine(getit(activenum));
                timer = 4.5f;
            }
        }

    }
    public Vector3 randomposition()
    {
        Vector3 spawnposition = ship.transform.position;

        //

        while (Vector3.Distance(ship.transform.position, spawnposition) < 20)
        {
            float ranx = Random.Range(-45, 21);
            float ranz = Random.Range(-33, 31);
            spawnposition = new Vector3(ranx, -0.43f, ranz);
        }
        return spawnposition;



    }
    IEnumerator getit(int activenum)
    {
        yield return new WaitForSeconds((activenum+1) * 2);
        Vector3 positiontospawn = randomposition();

        magicring1.SetActive(true);
        
        enemyentry.Play();
        
        magicring1.transform.position = new Vector3(positiontospawn.x, -1.61f, positiontospawn.z);
        appearparticle.Play();

        yield return new WaitForSeconds(1.01f);
        GameObject newenemy = enemyshippooling.instance.getpooledenemy();
        newenemy.transform.position = positiontospawn;

        //newenemy.transform.rotation = Quaternion.Euler(0, 0, 0);

    }


}
