using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



public class AiMove : MonoBehaviour
{
    private NavMeshAgent _navMesh;
    public Transform _moveTransform;

    private void Awake()
    {
        _navMesh = GetComponent<NavMeshAgent>();

        _navMesh.SetDestination(_moveTransform.position);
    }
    /* private void Start()
    {
        _navMesh.SetDestination(_moveTransform.position);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            ToggleMovement();
        }
    }
    private void Init()
    {
        _navMesh = GetComponent<NavMeshAgent>();
        _navMesh.isStopped = true;
    }

    private void ToggleMovement()
    {
        _navMesh.isStopped = !_navMesh.isStopped;
    } */
} 
