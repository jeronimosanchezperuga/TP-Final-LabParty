using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIMujer2 : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform[] waypoints;
    int waypointIndex;
    Vector3 target;
    private Animator Mujer2Animator;
    private bool checkIdle = false;

    void Start()
    {
        checkIdle = false;
        agent = GetComponent<NavMeshAgent>();
        UpdateDestination();
        Mujer2Animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (checkIdle == false)
        {
            if (Vector3.Distance(transform.position, target) < 1)
            {
                IterateWaypointIndex();
                UpdateDestination();
            }
        }

        if (Mujer2Animator != null)
        {
            if (Input.GetKeyDown(KeyCode.O))
            {
                Mujer2Animator.SetTrigger("Idle");
                checkIdle = true;
            }

            if (Input.GetKeyDown(KeyCode.G))
            {
                checkIdle = false;
            }
        }
    }

    void UpdateDestination()
    {
        target = waypoints[waypointIndex].position;
        agent.SetDestination(target);
    }

    void IterateWaypointIndex()
    {
        waypointIndex++;
        if (waypointIndex == waypoints.Length)
        {
            waypointIndex = 0;
        }
    }
}
