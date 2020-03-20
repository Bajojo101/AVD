using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class simpleGo : MonoBehaviour
{

    //[RequireComponent(typeof(NavMeshAgent))]
    NavMeshAgent agent;
    public Transform Destination;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent < NavMeshAgent >();
        agent.destination = Destination.transform.position;
    }


}
