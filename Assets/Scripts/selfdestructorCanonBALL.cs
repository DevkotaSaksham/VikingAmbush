using System.Collections;
using UnityEngine;

public class selfdestructorCanonBALL : MonoBehaviour, IballpoolingInterface
{
    

   
   
    public IEnumerator destroyer()
    {
        yield return new WaitForSeconds(2.3f);
        this.gameObject.SetActive(false);
    }
    public void calldestroyer()
    {
        StartCoroutine(destroyer());
    }




}
