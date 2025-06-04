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
}