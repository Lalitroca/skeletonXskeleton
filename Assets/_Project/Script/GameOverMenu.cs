using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class GameOverMenu : MonoBehaviour
{
    [SerializeField] private TMP_Text _gameOverWarning = null;
    [SerializeField] private TMP_Text _pointCount = null;
    [SerializeField] private TMP_Text _killCount = null;
    [SerializeField] private TMP_Text _deathCount = null;
    [SerializeField] private ScoreManager _scoreTracker = null;
    [SerializeField] private MatchManager _matchManager = null;
    [SerializeField] private GoBackToMenu _returnToMenu = null;
    private InputControls _inputs;
    private InputAction _tryAgain;
    private InputAction _goBack;
    public void Initialize()
    {
        _inputs = new InputControls();
        _tryAgain = _inputs.gameOverInput.TryAgain;
        _goBack = _inputs.gameOverInput.Return;
    }
    private void Awake() {
        Initialize();
    }
    private void OnEnable()
    {
        _inputs.gameOverInput.Enable();
        if(Configurations.configs.EndlessGameMode)
        {
            _gameOverWarning.text = "GAME OVER";
            _pointCount.text = _scoreTracker.Score.ToString() + " POINTS";
            _deathCount.text = _scoreTracker.Deaths.ToString() + " DEATHS";
        }
        else
        {
            _gameOverWarning.text = "TIME'S UP";
            _pointCount.text = "CONGRATULATIONS! YOU SURVIVED " + (int)_matchManager.TimeAlive/60 + " MINUTES";
            _deathCount.text = "";
        }
        _killCount.text = _scoreTracker.Kills.ToString() + " KILLS";

        _tryAgain.performed += tryAgain;
        _goBack.performed += goingBack;
    }

    private void OnDisable()
    {
        _inputs.gameOverInput.Disable();
        _tryAgain.performed -= tryAgain;
        _goBack.performed -= goingBack;
    }

    private void tryAgain(InputAction.CallbackContext click)
    {
        _inputs.gameOverInput.Disable();
        _matchManager.RestartMatch();
        gameObject.SetActive(false);
    }

    private void goingBack(InputAction.CallbackContext click)
    {
        _inputs.gameOverInput.Disable();
        _returnToMenu.GoBack();
    }
}
