using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterShooting : MonoBehaviour
{
    [SerializeField] protected Transform _shootingSpot = null;
    protected CharacterController _controller;
    [SerializeField] private CharacterData _character = null;
    private GameObject _gameManager;
    private SpawnPolls _spawner;

    public virtual CharacterShooting Initialize()
    {
        _controller = GetComponent<CharacterController>();
        _gameManager = _controller.retrievedGameManager;
        _spawner = _gameManager.GetComponentInChildren<SpawnPolls>();
        
        return this;
    }

    public virtual void InstantiateShot(float shotForce, Vector3 throwDirection)
    {
        GameObject shot = _spawner.SpawnFromPool(_character.weapon, GetShootingSpot(), null);
        Projectile shotController = shot.GetComponent<Projectile>();
        shotController.owner = this.gameObject;
        shotController.chargedTime = shotForce;
        shotController.ThrowProjectile(throwDirection);
    }

    protected virtual Vector3 GetShootingSpot()
    {
        return _shootingSpot.position;
    }
}
