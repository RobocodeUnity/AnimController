using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    private NavMeshAgent myAgent;
    private void Start()
    {
        myAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if(Physics.Raycast(myRay, out hitInfo))
            {
                myAgent.SetDestination(hitInfo.point);
            }
        }
        
    }
   
}
