using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyAI : MonoBehaviour
{
    public float speed;
    private Transform target;
    private NavMeshAgent agent;
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = target.transform.position;
    }
}
