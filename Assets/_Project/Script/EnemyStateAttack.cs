using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStateAttack : EnemyStateBase
{
    private float _cooldownTimer;

    public override void Initialize()
    {
        base.Initialize();
    }
    public override void stateBehaviour()
    {
        if(canSeePlayer())
        {
            transform.LookAt(_player.transform);
            if(_distanceToPlayer <= _enemyController.AttackRange)
            {
                if(_distanceToPlayer < 0.9f)
                {
                    _enemyMovement.MoveTo(transform.position - transform.forward.normalized);
                }
                if(_cooldownTimer < Time.time)
                {
                    _cooldownTimer = _enemyController.AttackCooldown + Time.time;
                    Attack();
                    Debug.Log(_enemyController.characterInfo.characterTag + " attacked!");
                } else
                {
                    //_enemyController.Block(_distanceToPlayer < _enemyController.DistanceToBlock);
                }
            }
            else
            {
                _enemyController.Block(false);
                _stateController.ChangeState(1);
            }
        } else
        {
            _enemyController.Block(false);
            _stateController.ChangeState(0);
        }
    }

    protected virtual void Attack()
    {
        _enemyController.Block(false);
        _enemyController.Attack();
    }
}
