using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public MovementStruct.MovementInfo _movementInfo;
    private CharactersAnimation _animator;
    private EnemyController _controller;
    private Vector3? _currentTarget = null;
    private NavMeshMovement _mover;
    private float _searchTimer;
    private bool _waiting = false;

    public EnemyMovement Initialize()
    {
        Debug.Log(this + " intialized");
        _mover = GetComponent<NavMeshMovement>().Initialize();
        _controller = GetComponent<EnemyController>();
        _animator = GetComponent<CharactersAnimation>();
        _movementInfo = new MovementStruct.MovementInfo();

        return this;
    }
    public void MoveTo(Vector3 pos)
    {
        if(_currentTarget != pos)
        {
            _currentTarget = pos;
            _mover.ShouldAutoBreak(true);
            _mover.MoveTowards(_currentTarget.GetValueOrDefault(), out _movementInfo);
        }
    }

    public void TurnTo(Vector3 pos)
    {
        Vector3 turnPoint = transform.position + (transform.position - pos).normalized;
        Debug.Log(turnPoint);
        MoveTo(turnPoint);        
    }

    public void SearchAround(float range, float waitForNextSearch = 0)
    {
        if(_mover.HasReached() && !_waiting)
        {
            _waiting = true;
            StartCoroutine(ContinueSearching(range, waitForNextSearch));
        }
    }

    private void Update()
    {
        _controller.MovementAnimation(_movementInfo);
    }

    private IEnumerator ContinueSearching(float range, float waitForNextSearch)
    {
        _searchTimer = Time.time + waitForNextSearch;

        yield return new WaitUntil(() => _searchTimer < Time.time);

        _mover.ShouldAutoBreak(false);
        _currentTarget = _mover.GetPositionOnNavMesh(transform.position, range);
        _mover.MoveTowards(_currentTarget.GetValueOrDefault(), out _movementInfo);
        _waiting = false;
    }
}
