using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIPeruga1 : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform[] waypoints;
    int waypointIndex;
    Vector3 target;

    void Start()
    {
        if (LogicaNPC.checkPeruga1 == false)
        {
            agent = GetComponent<NavMeshAgent>();
            UpdateDestination();
        }
    }

    void Update()
    {
        if (LogicaNPC.checkPeruga1 == false)
        {
            if (Vector3.Distance(transform.position, target) < 1)
            {
                IterateWaypointIndex();
                UpdateDestination();
            }
        }

        else
        {
            agent.velocity = Vector3.zero;
        }
    }

    void UpdateDestination()
    {
        if (LogicaNPC.checkPeruga1 == false)
        {
            target = waypoints[waypointIndex].position;
            agent.SetDestination(target);
        }

        else agent.velocity = Vector3.zero;
    }

    void IterateWaypointIndex()
    {
        if (LogicaNPC.checkPeruga1 == false)
        {
            waypointIndex++;
            if (waypointIndex == waypoints.Length)
            {
                waypointIndex = 0;
            }
        }

        else agent.velocity = Vector3.zero;
    }
}
