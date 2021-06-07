using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStateIdle : EnemyStateBase
{
    [SerializeField] private float _idleRange = 5f;
    [SerializeField] private float _timeBetweenSeaches = 3f;
    public override void stateBehaviour()
    {
        _enemyMovement._movementInfo.speed = _enemyController.characterInfo.baseSpeed;
        if(canSeePlayer())
        {
            _stateController.ChangeState(2);
        } else
        {
            _enemyMovement.SearchAround(_idleRange, _timeBetweenSeaches);
        }
    }
}
