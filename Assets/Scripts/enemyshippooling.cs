using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyshippooling : MonoBehaviour
{
    public static enemyshippooling instance;
    public GameObject enemyyprefab;
    private List<GameObject> pooledship = new List<GameObject>();

    void Awake()
    {
        instance = this;
    }


    void Start()
    {
        
        for (int i = 0; i < 5; i++)
        {
            GameObject enemy = Instantiate(enemyyprefab);
            enemy.SetActive(false);
            pooledship.Add(enemy);

        }
    }
    public GameObject getpooledenemy()
    {
        for (int i = 0; i < pooledship.Count; i++)
        {
            if (!pooledship[i].activeInHierarchy)
            {
                pooledship[i].SetActive(true);              
                return pooledship[i];
            }
        }

        return null;

    }
}
