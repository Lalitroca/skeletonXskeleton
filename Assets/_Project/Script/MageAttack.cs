using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MageAttack : EnemyStateAttack
{
    private CharacterShooting _shooterController;

    public override void Initialize()
    {
        base.Initialize();
        _shooterController = GetComponent<CharacterShooting>().Initialize();
    }
    public void AEvShoot()
    {
        _shooterController.InstantiateShot(1, transform.forward);
    }
}
