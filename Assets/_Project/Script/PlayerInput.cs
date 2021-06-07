using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    private MovementStruct.MovementInfo _playerInputValues;
    private PlayerMovement _playerMovement;
    private PlayerShooting _playerShooting;
    private InputControls _inputReciever;
    private Vector3 _movementInput;
    private InputAction _movementAction;
    private InputAction _shootAction;
    private InputAction _aimAction;
    private InputAction _jumpAction;
    private InputAction _runAction;
    private InputAction _cameraTurnAction;
    private float _cameraFacingDirection;

    public void Initialize()
    {
        Debug.Log(this + " intialized");
        _playerMovement = GetComponent<PlayerMovement>().Initialize();
        _playerShooting = GetComponent<PlayerShooting>();
        _playerShooting.Initialize();
        
        _playerInputValues = new MovementStruct.MovementInfo();

        MatchActions.OnMatchStarted += MatchStarted;
        MatchActions.OnMatchPaused += MatchPaused;
        MatchActions.OMatchEnded += MatchEnded;

        _inputReciever = new InputControls();
        _movementAction = _inputReciever.playerInputControl.MovementInput;
        _shootAction = _inputReciever.playerInputControl.ShootInput;
        _aimAction = _inputReciever.playerInputControl.AimInput;
        _jumpAction = _inputReciever.playerInputControl.Jump;
        _runAction = _inputReciever.playerInputControl.Run;
        _cameraTurnAction = _inputReciever.cameraInputControl.CameraAimInput;
        StartInputEvents();
    }
    private void Update()
    {
        _cameraFacingDirection = Camera.main.transform.eulerAngles.y;
        _playerInputValues.direction = Quaternion.Euler(0, _cameraFacingDirection, 0) * _movementInput;
        _playerMovement.RecieveInput(_playerInputValues);
    }
    private void OnDestroy()
    {
        MatchActions.OnMatchStarted -= MatchStarted;
        MatchActions.OnMatchPaused -= MatchPaused;
        MatchActions.OMatchEnded -= MatchEnded;

        EndInputEvents();
    }

    private void MatchStarted()
    {
        _inputReciever.playerInputControl.Enable();
    }
    private void MatchPaused(bool paused)
    {
        if(!paused)
        {
            _inputReciever.playerInputControl.Enable();
        } else
        {
            _inputReciever.playerInputControl.Disable();
        }
    }
    private void MatchEnded()
    {
        _inputReciever.playerInputControl.Disable();
    }

    private void MovementHandler(InputAction.CallbackContext movingTrigger)
    {
        Vector2 recievedInput = movingTrigger.ReadValue<Vector2>();
        _movementInput = new Vector3 (recievedInput.x, 0, recievedInput.y);
    }
    private void RunningHandler(InputAction.CallbackContext runTrigger)
    {
        _playerInputValues.running = runTrigger.ReadValueAsButton();
        _playerMovement.ChangeSpeedToRun(_playerInputValues);
    }
    private void JumpingHandler(InputAction.CallbackContext jumpTrigger)
    {
        _playerInputValues.jumping = jumpTrigger.ReadValueAsButton();
    }
    private void ShootingHandler(InputAction.CallbackContext shootingTrigger)
    {
        _playerShooting.Shooting(shootingTrigger.phase == InputActionPhase.Started);
    }

    private void CameraTurnHandler(InputAction.CallbackContext cameraTrigger)
    {
        _playerMovement.CameraTurn();
    }

    private void StartInputEvents()
    {
        _inputReciever.cameraInputControl.Enable();

        _cameraTurnAction.started += CameraTurnHandler;
        _cameraTurnAction.canceled += CameraTurnHandler;
        _cameraTurnAction.performed += CameraTurnHandler;

        _shootAction.started += ShootingHandler;
        _shootAction.canceled += ShootingHandler;
        _shootAction.performed += ShootingHandler;

        _movementAction.performed += MovementHandler;
        _movementAction.canceled += MovementHandler;
        
        _jumpAction.started += JumpingHandler;
        _jumpAction.canceled += JumpingHandler;
        _jumpAction.performed += JumpingHandler;

        _runAction.started += RunningHandler;
        _runAction.canceled += RunningHandler;
    }

    private void EndInputEvents()
    {
        _inputReciever.cameraInputControl.Disable();
        
        _cameraTurnAction.started -= CameraTurnHandler;
        _cameraTurnAction.canceled -= CameraTurnHandler;
        _cameraTurnAction.performed -= CameraTurnHandler;

        _shootAction.started -= ShootingHandler;
        _shootAction.canceled -= ShootingHandler;
        _shootAction.performed -= ShootingHandler;

        _movementAction.performed -= MovementHandler;
        _movementAction.canceled -= MovementHandler;
        
        _jumpAction.started -= JumpingHandler;
        _jumpAction.performed -= JumpingHandler;
        _jumpAction.canceled -= JumpingHandler;

        _runAction.started -= RunningHandler;
        _runAction.canceled -= RunningHandler;
    }
}
