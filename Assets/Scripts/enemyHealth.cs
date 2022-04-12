using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{
    public static enemyHealth instance;
    private int health;
    public float shootinterval = 3f;
    public float shoottimer = 3f;
    public float shootdistance = 23f;
    public GameObject explosion;
    public Transform explPos;

    // public GameObject enemyball;

    private Transform target;
    public Transform shootPosition;

    public AudioSource enemyballs;
    public AudioSource takendamage;


    private void Awake()
    {
        instance = this;

    }
    private void Start()
    {
        health = Random.Range(3, 5) * 10;
        target = GameObject.FindGameObjectWithTag("myship").transform;
    }
    void Update()
    {
        if (health < 1)
        {
            GameObject expl = CFX_SpawnSystem.GetNextObject(explosion);
            expl.transform.position = explPos.position;
            soundexplosion.instance.playexplosion();
            pointmanager.instance.scoreincrease();

            expl.SetActive(true);
            this.gameObject.SetActive(false);
            health = Random.Range(3, 5) * 10;
        }

        shoottimer -= Time.deltaTime;
        if (shoottimer <= 0 && Vector3.Distance(transform.position, target.position) <= shootdistance)
        {

            GameObject ball = ballpooling.instance.getpooledenemyball();
            enemyballs.Play();

            if (ball != null)
            {
                ball.transform.position = shootPosition.position;

                Rigidbody rb = ball.GetComponent<Rigidbody>();
                rb.velocity = shootPosition.up * 9.5f;
            }


            shoottimer = shootinterval;



        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag.Equals("canonball"))
        {
            takendamage.Play();

            decreaseenemyhealth(10);
        }
    }
    public void decreaseenemyhealth(int damage)
    {
        health -= damage;
    }


}
