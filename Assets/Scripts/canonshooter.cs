
using UnityEngine;
using EZCameraShake;

public class canonshooter : MonoBehaviour
{
    public AudioSource ballsound;

    [SerializeField]

    private float blastpower = 5f;
    //public GameObject canonball;
    //public postprocessing postprocess;
    void Start()
    {

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            blastpower = 3f;
        }


        if (blastpower < 15)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                blastpower += 0.2f;

            }
        }






        if (Input.GetKeyUp(KeyCode.Space))
        {
            GameObject ball = ballpooling.instance.getpooledcanonball();
            ballsound.Play();
            if (ball != null)
            {
                
                StartCoroutine(postprocessing.instance.screenaberate());
                ball.transform.position = transform.position;
                //ball.SetActive(true);
                Rigidbody rb = ball.GetComponent<Rigidbody>();
                rb.velocity = transform.up * blastpower;
            }
            CameraShaker.Instance.ShakeOnce(4.8f, 2.6f, 0.2f, 0.3f);



        }

    }
}
