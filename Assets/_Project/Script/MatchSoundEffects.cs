using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchSoundEffects : MonoBehaviour
{
    [SerializeField] private AudioClip _gameOverEndless = null;
    [SerializeField] private AudioClip _gameOverTimer = null;
    private AudioSource _matchAudioPlayer;
    public void Initialize()
    {
        _gameOverEndless.LoadAudioData();
        _gameOverTimer.LoadAudioData();
        _matchAudioPlayer = GetComponent<AudioSource>();
        MatchActions.OMatchEnded += EndMatch;
    }

    private void EndMatch()
    {
        if(Configurations.configs.EndlessGameMode)
        {
            _matchAudioPlayer.PlayOneShot(_gameOverEndless);
        } else
        {
            _matchAudioPlayer.PlayOneShot(_gameOverTimer);
        }
    }
}
