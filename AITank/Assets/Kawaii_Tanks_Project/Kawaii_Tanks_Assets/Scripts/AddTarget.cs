using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AddTarget : MonoBehaviour
{
    public GameObject target;
    NavMeshAgent mr;

    void Start()
    {
        mr = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        mr.SetDestination(target.transform.position);
    }
}
