﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveTo : MonoBehaviour
{
    RaycastHit hitInfo = new RaycastHit();
    
    NavMeshAgent agent;
    //public Transform goal;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray.origin,ray.direction,out hitInfo))
            {
                agent.destination = hitInfo.point;
            }
        }
 //       else
 //       {
 //           agent.destination = goal.transform.position;
 //       }
    }
}
