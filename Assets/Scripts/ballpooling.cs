using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballpooling : MonoBehaviour
{
    public static ballpooling instance;

    public GameObject enemyball;
    public GameObject canonball;

    private List<GameObject> pooledcanonball = new List<GameObject>();
    private List<GameObject> pooledenemyball = new List<GameObject>();


    void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        //for canonball
        for(int i = 0; i < 11; i++) {
            GameObject canball = Instantiate(canonball);
            canball.SetActive(false);
            pooledcanonball.Add(canball);
        
        }

        //for enemyball
        for (int i = 0; i < 6; i++)
        {
            GameObject enemball = Instantiate(enemyball);
            enemball.SetActive(false);
            pooledenemyball.Add(enemball);

        }

    }
    public GameObject getpooledcanonball() {
        for (int i = 0; i < pooledcanonball.Count; i++) {
            if (!pooledcanonball[i].activeInHierarchy) {

                
                pooledcanonball[i].SetActive(true);
                pooledcanonball[i].GetComponent<IballpoolingInterface>().calldestroyer();

                return pooledcanonball[i];
            }
        }

        return null;
    
    }

    public GameObject getpooledenemyball()
    {
        for (int i = 0; i < pooledenemyball.Count; i++)
        {
            if (!pooledenemyball[i].activeInHierarchy)
            {
                pooledenemyball[i].SetActive(true);
                pooledenemyball[i].GetComponent<IballpoolingInterface>().calldestroyer();
                return pooledenemyball[i];
            }
        }

        return null;
    }
   
   
}
