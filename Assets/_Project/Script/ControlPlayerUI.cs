using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ControlPlayerUI : MonoBehaviour
{
    [SerializeField] private SpawnPlayer _playerSpawner = null;
    [SerializeField] private MatchManager _matchManager = null;
    [SerializeField] private TMP_Text _ammoText = null;
    [SerializeField] private Image _healthBar = null;
    [SerializeField] private TMP_Text _matchTimeText = null;
    [SerializeField] private GameObject _damagedPanel = null;
    private GameObject _player;
    private Health _playerHealth;
    private AmmoManager _playerAmmo;
    private float _maxHealth;
    private float _matchDuration;
    private float _timer;
    private int _timerSeconds;
    private bool _matchHappening = false;
    public void SetUpUI()
    {
        _player = _playerSpawner.SpawnedPlayerObj;
        _playerHealth = _player.GetComponent<Health>();
        _playerAmmo = _player.GetComponent<AmmoManager>();
        _maxHealth = _playerHealth.CurrentHealth;
        _matchDuration = Configurations.configs.MatchTime;

        MatchActions.OnMatchStarted += StartMatch;
        MatchActions.OnMatchPaused += PauseMatch;
        MatchActions.OMatchEnded += EndMatch;

        ResetUI();
    }
    public IEnumerator DamageEffect()
    {
        _damagedPanel.SetActive(true);
        yield return new WaitForSeconds(0.8f);
        _damagedPanel.SetActive(false);
    }

    private void Update()
    {
        if(!_matchHappening)
        {
            return;
        }

        _ammoText.text = _playerAmmo.AmmoCount.ToString();
        _healthBar.fillAmount = _playerHealth.CurrentHealth / _maxHealth;
        if(Configurations.configs.EndlessGameMode)
        {
            _timer = _matchManager.TimeAlive;
        } else
        {
            _timer = _matchDuration - _matchManager.TimeAlive;
        }
        _timerSeconds = (int)_timer%60;
        if(_timerSeconds == 60)
        {
            _timerSeconds = 0;
        }
        _matchTimeText.text = string.Format("{0:00}:{1:00}", Mathf.Floor(_timer/60), _timerSeconds);
    }
    private void OnDisable()
    {
        MatchActions.OnMatchStarted -= StartMatch;
        MatchActions.OnMatchPaused -= PauseMatch;
        MatchActions.OMatchEnded -= EndMatch;
    }
    private void StartMatch()
    {
        _matchHappening = true;
    }

    private void PauseMatch(bool pause)
    {
        _matchHappening = !pause;
    }
    private void EndMatch()
    {
        _matchHappening = false;
        ResetUI();
    }
    private void ResetUI()
    {
        _matchTimeText.text = string.Format("{0:00}:{1:00}", 0,0);
        _healthBar.fillAmount = _maxHealth / _maxHealth;
        _ammoText.text = Configurations.configs.StartingAmmo.ToString();
    }
}
