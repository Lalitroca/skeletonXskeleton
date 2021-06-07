using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshMovement : MonoBehaviour
{
    private NavMeshAgent _navAgent;
    private EnemyController _enemyManager;
    private MovementStruct.MovementInfo _movementInfo;

    public NavMeshMovement Initialize()
    {
        Debug.Log(this + " intialized");
        _navAgent = GetComponent<NavMeshAgent>();
        _enemyManager = GetComponent<EnemyController>();
        _navAgent.stoppingDistance = _enemyManager.AttackRange;
        _movementInfo = new MovementStruct.MovementInfo();
        
        return this;
    }
    public void MoveTowards(Vector3 goal, out MovementStruct.MovementInfo info)
    {
        if(Vector3.Distance(transform.position, goal) <= _navAgent.stoppingDistance)
        {
            info = _movementInfo;
            return;
        }
        if(_navAgent.SetDestination(goal))
        {
            _navAgent.destination = goal;
        } else
        {
            _navAgent.destination = ValidatePath(transform.position, goal);
        }
        _movementInfo.direction = _navAgent.velocity;
        info = _movementInfo;
    }

    public void ShouldAutoBreak(bool autobreak)
    {
        _navAgent.autoBraking = autobreak;
    }

    public Vector3 GetPositionOnNavMesh(Vector3 initialPos, float range)
    {
        Vector2 newPositionV2 = Random.insideUnitCircle * range;
        Vector3 newPositionV3 = new Vector3(transform.position.x + newPositionV2.x, transform.position.y, transform.position.z + newPositionV2.y);
        return ValidatePath(initialPos, newPositionV3);
    }
    public bool HasReached()
    {
        if (Vector3.Distance(transform.position, _navAgent.destination) <= _navAgent.stoppingDistance)
        {
            _movementInfo.moving = false;
            return true;
        }
        else
        {
            _movementInfo.moving = true;
            return false;
        }
    }

    private Vector3 ValidatePath(Vector3 initialPos, Vector3 targetPos)
    {
        NavMeshHit hit;
        Debug.DrawRay(initialPos, targetPos, Color.green, 1);
        if(NavMesh.Raycast(initialPos, targetPos, out hit, 0))
        {
            Debug.Log("closest option to " + targetPos + " is " + hit.position);
            return hit.position;
        } else
        {
            return targetPos;
        }
    }
}
