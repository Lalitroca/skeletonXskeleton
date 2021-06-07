using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private CharacterData _characterInfo = null;
    [SerializeField] private Transform _arms = null;
    private MovementStruct.MovementInfo _movementInfo;
    private Rigidbody _body;
    private CharacterController _controller;
    private Collider _bodyCollider;
    private float _distanceToGround;
    private Vector3 _nextMove;
    private Camera _cam;
    private float _cameraAimingDirection;
    private float _cameraFacingDirection;

    public PlayerMovement Initialize()
    {
        Debug.Log(this + " intialized");
        _body = GetComponent<Rigidbody>();
        _bodyCollider = GetComponent<Collider>();
        _controller = GetComponent<CharacterController>();
        _movementInfo = new MovementStruct.MovementInfo();
        _cam = Camera.main;
        
        _movementInfo.running = false;
        ChangeSpeedToRun(_movementInfo);

        return this;
    }

    public void RecieveInput(MovementStruct.MovementInfo move)
    {
        _movementInfo.direction = move.direction;
        _movementInfo.jumping = move.jumping;
        _nextMove = _movementInfo.direction * _movementInfo.speed;
    }
    public void ChangeSpeedToRun(MovementStruct.MovementInfo input)
    {
        _movementInfo.running = input.running;

        if(Configurations.configs.ConstantRunning)
        {
            _movementInfo.running = !_movementInfo.running;
        }

        if(_movementInfo.running)
        {
            _movementInfo.speed = _characterInfo.runningSpeed;
        } else
        {
            _movementInfo.speed = _characterInfo.baseSpeed;
        }
    }
    public void SlowDownToAim(bool isAiming)
    {
        if(isAiming)
        {
            _movementInfo.speed = _movementInfo.speed/2;
        }
        else
        {
            _movementInfo.speed = _characterInfo.baseSpeed;
        }
    }
    public void CameraTurn()
    {
        _cameraFacingDirection = _cam.transform.eulerAngles.y;
        transform.rotation = Quaternion.Euler(0, _cameraFacingDirection, 0);
        _cameraAimingDirection = - _cam.transform.eulerAngles.x;
        _arms.rotation = Quaternion.Euler(_cameraAimingDirection, _arms.rotation.eulerAngles.y, _arms.rotation.eulerAngles.z);
    }
    private void FixedUpdate()
    {
        if(_movementInfo.jumping)
        {
            _nextMove.y = _characterInfo.jumpForce;
            _movementInfo.jumping = false;
        }
        
        _movementInfo.moving = (_movementInfo.direction != Vector3.zero);
        _body.MovePosition(transform.position + (_nextMove * Time.deltaTime));
        _controller.MovementAnimation(_movementInfo);
    }
    private bool isOnGround()
    {
        _distanceToGround = _bodyCollider.bounds.extents.y;
        return Physics.Raycast(_bodyCollider.bounds.center, Vector3.down, _distanceToGround + 0.1f);
    }
}
