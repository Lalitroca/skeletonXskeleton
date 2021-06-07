using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PlayerShooting : CharacterShooting
{
    [SerializeField] private GameObject _arrowObject = null;
    [SerializeField] private Transform _arrowHeadTransform = null;
    [SerializeField] private float _minTriggerTime = 0.25f;
    private AmmoManager _ammoManager;
    private AimUIControl _aimUIAnimator;
    private PlayerMovement _playerMovement;
    private PlayerAnimation _anim;
    private CinemachineVirtualCamera _camera;
    private float _cooldownTimer = 0;
    private float _startShootingTime;
    private bool _isAiming;

    public override CharacterShooting Initialize()
    {
        base.Initialize();
        _camera = _controller.retrievedCamera;
        _aimUIAnimator = _controller.retrievedCanvas.GetComponentInChildren<AimUIControl>();
        _anim = GetComponent<PlayerAnimation>();
        _ammoManager = GetComponent<AmmoManager>().Initialize();
        _playerMovement = GetComponent<PlayerMovement>();

        return this;
    }

    public void Shooting(bool isShooting)
    {
        if(!CanShoot())
        {
            Debug.Log("Can't shoot anymore");
            Aim(false);
            return;
        }
        if(isShooting)
        {
            _startShootingTime = Time.time;
        }
        else if(_isAiming && ShootTimer >= _minTriggerTime)
        {
            InstantiateShot(ShootTimer, _arrowHeadTransform.forward);
        }
        Aim(isShooting);
        _arrowObject.SetActive(isShooting);
    }
    public void Aim(bool isAiming)
    {
        _isAiming = isAiming;
        _controller.Aim(isAiming);
        if(!isAiming)
        {
            _arrowObject.SetActive(isAiming);
        }
        _playerMovement.SlowDownToAim(isAiming);
    }
    public override void InstantiateShot(float shotForce, Vector3 throwDirection)
    {
        base.InstantiateShot(shotForce, throwDirection);
        _anim.AEvShoot();
        _cooldownTimer = Time.time + _controller.AttackCooldown;
        _ammoManager.ChangeAmmoAmmount(-1);
    }
    protected override Vector3 GetShootingSpot()
    {
        return _arrowHeadTransform.position;
    }
    private void Update()
    {
        if(_isAiming)
        {
            _anim.PullArrow(ShootTimer);
        }
    }

    private bool CanShoot ()
    {
        return _cooldownTimer < Time.time && _ammoManager.AmmoCount > 0;
    }

    public float ShootTimer
    {
        get
        {
            return Time.time - _startShootingTime;
        }
    }
}
