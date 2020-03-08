using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CubeMover : MonoBehaviour
{
    public Rigidbody rb;
    public NavMeshAgent navMesh;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        navMesh = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        Debug.Log(navMesh.velocity.magnitude);
       
        if (Input.GetMouseButtonDown(0))
        {
            Ray nashRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if(Physics.Raycast(nashRay, out hitInfo))
            {
                navMesh.SetDestination(hitInfo.point);
            }
        }
    }
}
