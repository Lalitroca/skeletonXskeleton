using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatePersue : EnemyStateBase
{
    [SerializeField] private float _persueRange = 2f;
    [SerializeField] private float _timeBetweenSeaches = 1f;
    [SerializeField] private float _persueSearchTime = 3f;
    private float _timeLookingAround = 0;
    public override void stateBehaviour()
    {
        if(canSeePlayer())
        {
            transform.LookAt(_player.transform);
            _enemyMovement._movementInfo.speed = _enemyController.characterInfo.runningSpeed;

            if(_distanceToPlayer > _enemyController.AttackRange)
            {
                _enemyMovement.MoveTo(_playerPosition);
            } else
            {
                _stateController.ChangeState(2);
            }
        } else
        {
            _enemyMovement._movementInfo.speed = _enemyController.characterInfo.baseSpeed;

            if(_timeLookingAround < Time.time)
            {
                _timeLookingAround = _persueSearchTime + Time.time;
                _enemyMovement.SearchAround(_persueRange, _timeBetweenSeaches);
            } else
            {
                _stateController.ChangeState(0);
            }
        }
    }
}
