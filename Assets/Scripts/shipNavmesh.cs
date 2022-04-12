
using UnityEngine;
using UnityEngine.AI;

public class shipNavmesh : MonoBehaviour
{
    private NavMeshAgent navagent;

    private Transform target;
    void Start()
    {
        navagent = GetComponent<NavMeshAgent>();
        navagent.speed = Random.Range(0.2f, 1.8f);
        target = GameObject.FindGameObjectWithTag("myship").transform;

    }

    
    void Update()
    {
        Vector3 destination = target.position;
        navagent.SetDestination(destination);
        
        transform.LookAt(target);
    }
}
