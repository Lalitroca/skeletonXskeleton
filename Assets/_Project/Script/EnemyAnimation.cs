using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimation : CharactersAnimation
{
    private EnemyStates _stateManager;

    public override CharactersAnimation Initialize()
    {
        _stateManager = GetComponent<EnemyStates>();
        base.Initialize();

        return this;
    }

    public void StartPersuit()
    {
        _soundEffects.PlaySoundEffect(_soundEffects._spotEnemySound);
    }
    
    public void ReturnToIdle()
    {
        StartCoroutine(GruntOverTime(Random.Range(1,5)));
    }

    private IEnumerator GruntOverTime(float timeBetweenGrunts)
    {
        yield return new WaitForSeconds(timeBetweenGrunts);
        if(_stateManager.CurrentState != 0)
        {
            yield break;
        }

        _soundEffects.PlaySoundEffect(_soundEffects._idleGruntSound);

        StartCoroutine(GruntOverTime(Random.Range(6f,11)));
    }
}
