using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStateHeadToPosition : EnemyStateBase
{
    [SerializeField] private float _idleRange = 5f;
    [SerializeField] private float _timeBetweenSeaches = 3f;
    private StrategicPoint[] _strategicPositions = null;
    private StrategicPoint _chosenPos = null;
    private float _closerDist;

    public override void Initialize() {
        base.Initialize();
        _strategicPositions = GameObject.Find("StrategicPoints").GetComponentsInChildren<StrategicPoint>();
    }

    public override void stateBehaviour()
    {
        if(canSeePlayer())
        {
            _stateController.ChangeState(2);
        } else
        {
            StrategicPoint closerPoint;
            if(GetCloserPosition(out closerPoint))
            {
                _enemyMovement.MoveTo(closerPoint.Position);
            } else
            {
                _enemyMovement.SearchAround(_idleRange, _timeBetweenSeaches);
            }
        }
    }

    private bool GetCloserPosition(out StrategicPoint newPos)
    {
        if(_chosenPos == null)
        {
            _closerDist = 1000;
        } else
        {
            _closerDist = Vector3.Distance(transform.position, _chosenPos.Position);
        }
        
        int newPosNumb = -1;
        for(int i = 0; i < _strategicPositions.Length; i++)
        {
            if(_strategicPositions[i].AssignedEnemy == null)
            {
                if(Vector3.Distance(transform.position, _strategicPositions[i].Position) < _closerDist)
                {
                    newPosNumb = i;
                }
            }
        }
        if(newPosNumb < 0)
        {
            newPos = _chosenPos;
            return false;
        } else
        {
            newPos = _strategicPositions[newPosNumb];
            newPos.AssignedEnemy = this.gameObject;
            return true;
        }
    }
}
