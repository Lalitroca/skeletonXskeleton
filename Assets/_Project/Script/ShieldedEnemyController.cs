using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldedEnemyController : EnemyController
{
    [SerializeField] private AnimatorOverrideController _animatorWithShield = null;
    [SerializeField] private AnimatorOverrideController _animatorWithoutShield = null;
    [SerializeField] private float _noShieldAttackCooldown = 1;
    [SerializeField] private float _noShieldDistanceToBlock = 0;
    private ShieldController _shieldController;
    private float _defaultAttackCooldown;
    private float _defaultDistanceToBlock;
    private Animator _animator;
    public override CharacterController Initialize()
    {
        _defaultAttackCooldown = AttackCooldown;
        _defaultDistanceToBlock = DistanceToBlock;
        _shieldController = GetComponentInChildren<ShieldController>();
        _shieldController.Initialize();
        _animator = GetComponent<Animator>();
        base.Initialize();

        return this;
    }
    public override void IOnObjectSpawn()
    {
        base.IOnObjectSpawn();
        _shieldController.gameObject.SetActive(true);
        AttackCooldown = _defaultAttackCooldown;
        DistanceToBlock = _defaultDistanceToBlock;
        _animator.runtimeAnimatorController = _animatorWithShield;
    }

    public void LoseShield()
    {
        AttackCooldown = _noShieldAttackCooldown;
        DistanceToBlock = _noShieldDistanceToBlock;
        _animator.runtimeAnimatorController = _animatorWithoutShield;
    }
}
