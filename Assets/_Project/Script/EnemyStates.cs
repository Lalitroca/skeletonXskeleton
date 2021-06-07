using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(EnemyStateBase))]
public class EnemyStates : MonoBehaviour
{
    [SerializeField] private EnemyStateBase[] _states = null;
    private EnemyAnimation _anim;

    public EnemyStates Initialize()
    {
        _anim = GetComponent<EnemyAnimation>();

        foreach(EnemyStateBase state in _states)
        {
            state.Initialize();
        }

        return this;
    }
    public void ChangeState (int nextState)
    {
        if(nextState == CurrentState)
        {
            return;
        }

        if(nextState == 0)
        {
            _anim.ReturnToIdle();
        }
        else if(nextState == 1 && CurrentState == 0)
        {
            _anim.StartPersuit();
        }

        this.CurrentState = nextState;
        Debug.Log(this.gameObject.name + " changed state to " + this.CurrentState);
    }

    private void Update()
    {
        GetStateFromInt(CurrentState).stateBehaviour();
    }
    private EnemyStateBase GetStateFromInt(int state)
    {
        return _states[state];
    }
    
    public int CurrentState {get; private set;}
}
