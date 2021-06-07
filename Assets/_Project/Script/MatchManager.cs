using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class MatchManager : MonoBehaviour
{
    [SerializeField] private SpawnPlayer _playerSpawner = null;
    [SerializeField] private SpawnPolls _poolsSpawner = null;
    [SerializeField] private GameObject _countdownPanel = null;
    [SerializeField] private TMP_Text _countdown = null;
    [SerializeField] private GameObject _gameoverPanel = null;
    [SerializeField] private GameObject _pausePanel = null;
    [SerializeField] private int _countdownToStart = 3;
    [SerializeField] private int _countdownToRevive = 3;
    private ScoreManager _scoreTracker;
    private AudioSource _audioPlayer;
    private float _matchTime = 180;
    private float _matchStartTime;
    private bool _endlessMode = false;
    private bool _paused = false;
    private bool _matchStarted = false;
    private InputControls _inputs;
    private InputAction _pauseAction;

    public void RestartMatch()
    {
        _audioPlayer.Play();
        _matchStarted = false;
        StartCoroutine(MatchCountdown(_countdownToStart));
    }

    public void PauseMatch(bool pause)
    {
        _paused = pause;

        Cursor.visible = _paused;
        _pausePanel.SetActive(_paused);

        if(_paused)
        {
            _inputs.cameraInputControl.Disable();
            Time.timeScale = 0;
        } else
        {
            _inputs.cameraInputControl.Enable();
            Time.timeScale = 1;
        }

        MatchActions.OnMatchPaused(_paused);
    }

    public void EndMatch()
    {
        Cursor.visible = true;
        if(_countdownPanel.activeSelf)
        {
            _countdownPanel.SetActive(false);
        }
        
        MatchActions.OMatchEnded();

        _inputs.matchInputs.Disable();
        _audioPlayer.Pause();
        _gameoverPanel.SetActive(true);
        _matchStarted = false;
    }
    public void RevivePlayer()
    {
        StartCoroutine(MatchCountdown(_countdownToRevive));
    }

    private void Start()
    {
        Initialize();
    }
    private void OnDestroy() {
        _pauseAction.performed -= HandlePauseInput;
    }

    private void Initialize()
    {
        AudioListener.volume = Configurations.configs.SoundVolume;

        _matchTime = Configurations.configs.MatchTime;
        _endlessMode = Configurations.configs.EndlessGameMode;
        
        _inputs = new InputControls();
        _pauseAction = _inputs.matchInputs.Pause;
        _pauseAction.performed += HandlePauseInput;

        _scoreTracker = GetComponent<ScoreManager>().Initialize();
        _audioPlayer = GetComponent<AudioSource>();
        GetComponentInChildren<MatchSoundEffects>().Initialize();
        _poolsSpawner.Initialize();
        _playerSpawner.Initialize();

        StartCoroutine(MatchCountdown(_countdownToStart));
    }

    private void StartMatch()
    {
        _matchStarted = true;
        if(!_endlessMode)
        {
            Invoke("EndMatch", _matchTime);
        }
        _matchStartTime = Time.time;

        MatchActions.OnMatchStarted();
    }
    private IEnumerator MatchCountdown(int time)
    {
        Cursor.visible = false;
        _gameoverPanel.SetActive(false);
        _countdownPanel.SetActive(true);
        _inputs.matchInputs.Enable();
        for(int i = time; i > -1; i--)
        {
            _countdown.text = i.ToString();
            yield return new WaitForSeconds(1);
        }
        if(!_countdownPanel.activeSelf)
        {
            yield break;
        }
        _countdownPanel.SetActive(false);

        _playerSpawner.ResetPlayer();

        if(!_matchStarted)
        {
            StartMatch();
        }
        else
        {
            Debug.Log("Match has already started!");
        }
    }

    private void HandlePauseInput(InputAction.CallbackContext pause)
    {
        PauseMatch(!_paused);
    }

    public float TimeAlive
    {
        get
        {
            return Time.time - _matchStartTime;
        }
        private set {}
    }
}
