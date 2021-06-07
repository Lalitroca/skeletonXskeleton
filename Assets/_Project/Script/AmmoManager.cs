using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoManager : MonoBehaviour
{
    private int _startingAmmo;

    public AmmoManager Initialize()
    {
        _startingAmmo = Configurations.configs.StartingAmmo;
        MatchActions.OnMatchStarted += OnStart;
        MatchActions.OMatchEnded += OnEnd;
        
        return this;
    }

    public void OnStart()
    {
        AmmoCount = _startingAmmo;
    }
    public void OnEnd()
    {
        AmmoCount = Configurations.configs.StartingAmmo;
    }

    public void ChangeAmmoAmmount(int ammount)
    {
        AmmoCount += ammount;
    }

    public void FillUpAmmo()
    {
        if(AmmoCount < _startingAmmo)
        {
            AmmoCount = _startingAmmo;
        }
    }

    private void OnDisable()
    {
        MatchActions.OnMatchStarted -= OnStart;
        MatchActions.OMatchEnded -= OnEnd;
    }
    public int AmmoCount {get; private set;}
}
