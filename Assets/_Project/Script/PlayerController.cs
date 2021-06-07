using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : CharacterController
{
    public GameObject _playersEyes;
    private SpawnPlayer _playerSpawner;
    private ControlPlayerUI _playerUI;

    public override CharacterController Initialize()
    {
        _playerSpawner = retrievedGameManager.GetComponentInChildren<SpawnPlayer>();
        _playerUI = retrievedCanvas.GetComponentInChildren<ControlPlayerUI>();
        _playerUI.SetUpUI();
        GetComponent<PlayerInput>().Initialize();
        base.Initialize();

        return this;
    }
    public override void IOnDamaged(GameObject striker)
    {
        base.IOnDamaged(striker);
        _playerUI.StartCoroutine("DamageEffect");
    }

    public override void Death()
    {
        base.Death();
        if(Configurations.configs.EndlessGameMode)
        {
            MatchActions.OMatchEnded();
            gameObject.SetActive(false);
        }
        else
        {
            StartCoroutine(DeathDelay());            
        }
    }
    private IEnumerator DeathDelay()
    {
        yield return new WaitForSeconds(1);
        _scoreTracker.UpDeathCount();
        _playerSpawner.RespawnPlayer();
    }
}
