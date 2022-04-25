using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyController : MonoBehaviour
{
    public Transform follow;
    NavMeshAgent agent;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    { 
        if (timer <= 0)
        {
            agent.SetDestination(follow.position);
            timer = 1;
        }
        timer -= Time.deltaTime;
        
    }
}
