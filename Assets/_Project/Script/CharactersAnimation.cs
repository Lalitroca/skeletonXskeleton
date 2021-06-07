using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactersAnimation : MonoBehaviour
{
    
    [Header("Components")]
    protected Animator _animator;
    private Rigidbody _body;
    protected CharacterSoundEffects _soundEffects;

    public virtual CharactersAnimation Initialize()
    {
        Debug.Log(this + " intialized");
        _animator = GetComponent<Animator>();
        _body = GetComponent<Rigidbody>();
        _soundEffects = GetComponent<CharacterSoundEffects>().Initialize();

        return this;
    }

    public void TriggerAimAnimation()
    {
        _animator.SetTrigger(AnimatorParameters.AIM);
    }

    public void TriggerAttackAnimation()
    {
        _animator.SetTrigger(AnimatorParameters.ATTACK);
    }

    public virtual void TriggerDamaged()
    {
        _soundEffects.PlaySoundEffect(_soundEffects._damageSound);
        _animator.SetTrigger(AnimatorParameters.DAMAGED);
    }

    public virtual void TriggerDeathAnimation()
    {
        _soundEffects.PlaySoundEffect(_soundEffects._deathSound);
        _animator.SetTrigger(AnimatorParameters.DEATH);
    }

    public virtual void AnimateMovement(MovementStruct.MovementInfo info)
    {
        _animator.SetBool(AnimatorParameters.MOVING, info.moving);
        _animator.SetFloat(AnimatorParameters.HORIIZONTAL_MOVEMENT, info.direction.x);
        _animator.SetFloat(AnimatorParameters.VERTICAL_MOVEMENT, info.direction.z);
        _animator.SetFloat(AnimatorParameters.SPEED, info.speed);
    }

    public void AEvShoot()
    {
        Debug.Log("Shot");
        _soundEffects.PlaySoundEffect(_soundEffects._attackSound);
    }

    public void AEvHit()
    {
        _soundEffects.PlaySoundEffect(_soundEffects._attackSound);
    }

    public void ChangeBoolParameter(string parameter, bool value)
    {
        _animator.SetBool(parameter, value);
    }

    public void FootR(){}
    public void FootL(){}
}
