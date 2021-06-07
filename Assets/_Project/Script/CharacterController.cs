using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CharacterController : MonoBehaviour, IDamagable
{
    public CharacterData characterInfo = null;
    [SerializeField] protected float _attackRange = 2;
    [SerializeField] protected float _attackCooldown = 2;
    protected CharactersAnimation _anim;
    protected ScoreManager _scoreTracker;

    public virtual CharacterController Initialize()
    {
        _scoreTracker = retrievedGameManager.GetComponent<ScoreManager>();
        _anim = GetComponent<CharactersAnimation>().Initialize();
        GetComponent<Health>().Initialize();

        return this;
    }
    public virtual void IOnDamaged(GameObject striker)
    {
        _anim.TriggerDamaged();
    }
    public virtual void MovementAnimation(MovementStruct.MovementInfo movement)
    {
        _anim.AnimateMovement(movement);
    }
    public void Aim(bool aiming)
    {
        _anim.ChangeBoolParameter(AnimatorParameters.AIM, aiming);
    }
    public virtual void Attack()
    {
        _anim.TriggerAttackAnimation();
    }
    public virtual void Death()
    {
        _scoreTracker.GetPoint(characterInfo.pointWorth);
        _anim.TriggerDeathAnimation();
    }
    public GameObject retrievedGameManager {get; set;}
    public GameObject retrievedCanvas {get; set;}
    public CinemachineVirtualCamera retrievedCamera {get; set;}
    public float AttackRange
    {
        get => _attackRange;
    }
    public float AttackCooldown
    {
        get => _attackCooldown;
        set => value = _attackCooldown;
    }
}
