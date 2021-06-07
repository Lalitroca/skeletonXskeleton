using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(EnemyStates))]
[RequireComponent(typeof(CharactersAnimation))]
public class EnemyController : CharacterController, IPoolManager
{
    [SerializeField] private float _summonSicknessTime = 2f;
    [SerializeField] private float _distanceToBlock = 3;
    [SerializeField] private float _viewDistance = 10;
    private EnemySpawner _enemySpawn;
    private DropItem _itemDrop;
    private EnemyStates _enemyState;
    private EnemyMovement _enemyMover;

    public override CharacterController Initialize()
    {
        Debug.Log(this + " intialized");
        _itemDrop = GetComponent<DropItem>().Initialize();
        _enemyState = GetComponent<EnemyStates>().Initialize();
        _enemyMover = GetComponent<EnemyMovement>();
        _enemySpawn = retrievedGameManager.GetComponentInChildren<EnemySpawner>();
        base.Initialize();

        return this;
    }

    public virtual void IOnObjectSpawn()
    {
        StartCoroutine(SummonSickness());
    }

    public override void IOnDamaged(GameObject striker) {
        base.IOnDamaged(striker);
        _enemyMover.TurnTo(striker.transform.position);
    }
    public override void MovementAnimation(MovementStruct.MovementInfo movement)
    {
        movement.moving = (movement.direction.magnitude > 0);
        if(movement.moving)
        {
            Block(false);
        }
        base.MovementAnimation(movement);
    }
    public void Block(bool isBlocking)
    {
        _anim.ChangeBoolParameter(AnimatorParameters.BLOCKING, isBlocking);
    }
    public override void Death()
    {
        base.Death();
        _enemyState.enabled = false;
        _scoreTracker.UpKillCount();
        
        if(_itemDrop != null)
        {
            _itemDrop.DropTheItem();
        }
        StartCoroutine(DisposeOfBody());
    }

    private IEnumerator SummonSickness()
    {
        yield return new WaitForSeconds(_summonSicknessTime);
        _enemyState.enabled = true;
        _enemyState.ChangeState(0);

    }
    private IEnumerator DisposeOfBody()
    {
        yield return new WaitForSeconds(2);
        gameObject.SetActive(false);
        _enemySpawn.StartCoroutine("SpawnNewEnemy");
    }

    public float DistanceToBlock
    {
        get => _distanceToBlock;
        set => _distanceToBlock = value;
    }
    public float ViewDistance
    {
        get => _viewDistance;
    }
}
