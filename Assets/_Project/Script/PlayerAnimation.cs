using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PlayerAnimation : CharactersAnimation
{
    [SerializeField] private float _camShakeIntesity = 10;
    [SerializeField] private float _camShakeDuration = 2;
    private CinemachineVirtualCamera _cam;
    private CinemachineBasicMultiChannelPerlin _camPerlinChannel;
    private bool canShakeArrow;

    public override CharactersAnimation Initialize()
    {
        base.Initialize();
        _cam = GetComponent<PlayerController>().retrievedCamera;
        _camPerlinChannel = _cam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();

        return this;
    }

    public override void AnimateMovement(MovementStruct.MovementInfo info)
    {
        _animator.SetFloat(AnimatorParameters.SPEED, info.direction.magnitude * (info.speed/4));
    }

    public override void TriggerDamaged()
    {
        _soundEffects.PlaySoundEffect(_soundEffects._damageSound);
        StartCoroutine(CameraShake());
    }

    public override void TriggerDeathAnimation()
    {
        _soundEffects.PlaySoundEffect(_soundEffects._deathSound);
    }

    public void PullArrow(float pullTime)
    {
        _animator.SetFloat(AnimatorParameters.ARROW_PULL, pullTime);
    }

    public void AEvPrepareAttack()
    {
        _soundEffects.PlaySoundEffect(_soundEffects._aimSound);
        canShakeArrow = true;
    }

    public void AEvArrowShake()
    {
        if(canShakeArrow)
        {
            _soundEffects.PlaySoundEffect(_soundEffects._bowStretchOutSound);
            canShakeArrow = false;
        }
    }

    private IEnumerator CameraShake()
    {
        Debug.Log("Camera shake");
        _camPerlinChannel.m_AmplitudeGain = 1;
        _camPerlinChannel.m_FrequencyGain = _camShakeIntesity;
        yield return new WaitForSeconds(_camShakeDuration);
        _camPerlinChannel.m_AmplitudeGain = 0;
        _camPerlinChannel.m_FrequencyGain = 0;
    }
}
