using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crystalpooler : MonoBehaviour
{
    private float timer = 3f;
    

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            StartCoroutine(spawning());
            timer = 4f;
        }
    }
    IEnumerator spawning()
    {
        int randomtime = Random.Range(2, 8);
        yield return new WaitForSeconds(randomtime);
        Vector3 position = enemyspawner.instance.randomposition();
        Vector3 tobespawned = new Vector3(position.x, 1.42f, position.z);

        MyPooler.ObjectPooler.Instance.GetFromPool("crystal", tobespawned, Quaternion.identity);

    }
}

