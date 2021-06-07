using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyStateBase : MonoBehaviour
{
    protected EnemyStates _stateController;
    protected GameObject _player;
    //protected FieldOfView _view;
    protected EnemyController _enemyController;
    protected EnemyMovement _enemyMovement;
    protected Vector3 _playerPosition;
    protected float _distanceToPlayer;
    
    public virtual void Initialize()
    {
        Debug.Log(this + " initialized");
        _stateController = GetComponent<EnemyStates>();
        _enemyController = GetComponent<EnemyController>();
        //_view = GetComponent<FieldOfView>();
        _enemyMovement = GetComponent<EnemyMovement>().Initialize();
        _player = _enemyController.retrievedGameManager.GetComponentInChildren<SpawnPlayer>().SpawnedPlayerObj;
        MatchActions.OnMatchStarted += GetPlayer;
    }
    public virtual void stateBehaviour() {}

    protected bool canSeePlayer()
    {
        _playerPosition = _player.transform.position;
        _distanceToPlayer = Vector3.Distance(transform.position, _playerPosition);
        return _distanceToPlayer <= _enemyController.ViewDistance;
    }
    private void OnDestroy()
    {
        MatchActions.OnMatchStarted -= GetPlayer;
    }
    private void GetPlayer()
    {
        _player = _enemyController.retrievedGameManager.GetComponentInChildren<SpawnPlayer>().SpawnedPlayerObj;
    }
}
