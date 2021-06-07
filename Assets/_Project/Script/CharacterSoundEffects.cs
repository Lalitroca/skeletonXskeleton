using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSoundEffects : MonoBehaviour
{
    [Header("General Audios")]
    public AudioClip _damageSound = null;
    public AudioClip _deathSound = null;
    public AudioClip _attackSound = null;

    [Header("Player Audios")]
    public AudioClip _bowStretchOutSound = null;
    public AudioClip _aimSound = null;
    
    [Header("Enemy Audios")]
    public AudioClip _spotEnemySound = null;
    public AudioClip _idleGruntSound = null;

    private AudioSource _soundPlayer;

    public CharacterSoundEffects Initialize()
    {
        _soundPlayer = GetComponent<AudioSource>();

        return this;
    }
    public void PlaySoundEffect(AudioClip sound)
    {
        if(_soundPlayer != null && sound != null)
        {
            Debug.Log("Playing " + sound);
            _soundPlayer.PlayOneShot(sound);
        }
    }
}
