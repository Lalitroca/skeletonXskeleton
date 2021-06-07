using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Cinemachine;

public class SpawnPlayer : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private GameObject _gameManager = null;
    [SerializeField] private GameObject _playerObj = null;
    [SerializeField] private Transform _playerSpawnPoint = null;
    [SerializeField] private GameObject _canvas = null;
    [SerializeField] private CameraFindPlayer _camFollower = null;
    [SerializeField] private CinemachineVirtualCamera _cinemachine = null;
    private MatchManager _matchManager;
    private CharacterController _playerManager;
    public void Initialize()
    {
        Debug.Log(this + " intialized");
        SpawnedPlayerObj = Instantiate(_playerObj, _playerSpawnPoint.position, _playerSpawnPoint.rotation);
        _playerManager = SpawnedPlayerObj.GetComponent<PlayerController>();
        _matchManager = _gameManager.GetComponent<MatchManager>();

        _playerManager.retrievedGameManager = _gameManager;
        _playerManager.retrievedCanvas = _canvas;
        _playerManager.retrievedCamera = _cinemachine;
        _playerManager.Initialize();
        _camFollower.setCamFollow(SpawnedPlayerObj.GetComponent<PlayerController>()._playersEyes);
    }

    public void RespawnPlayer()
    {
        SpawnedPlayerObj.SetActive(false);
        _matchManager.RevivePlayer();
    }

    public void ResetPlayer()
    {
        Debug.Log("Reseting player...");
        SpawnedPlayerObj.transform.position = _playerSpawnPoint.position;
        SpawnedPlayerObj.transform.rotation = _playerSpawnPoint.rotation;
        SpawnedPlayerObj.SetActive(true);
        _camFollower.setCamFollow(SpawnedPlayerObj.GetComponent<PlayerController>()._playersEyes);
    }
    public GameObject SpawnedPlayerObj {get; private set;}
}
