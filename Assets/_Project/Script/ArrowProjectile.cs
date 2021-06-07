using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowProjectile : Projectile
{
    [SerializeField] private Collider _pickableCollider = null;
    [SerializeField] private float _maxSpeed = 70;
    private ItemPickUpBase _itemToDrop;
    private float _baseSpeed;

    public override void Initialize()
    {
        base.Initialize();
        _itemToDrop = GetComponent<ItemPickUpBase>();
        _baseSpeed = _projectileSpeed;
    }

    public override void ThrowProjectile(Vector3 forceOriginDirection)
    {
        _projectileSpeed = _baseSpeed * ((chargedTime * 10));
        Debug.Log("charged for " + chargedTime + " speed " + _projectileSpeed + " damage " + (_damage + (chargedTime * 3.5f)));
        if(_projectileSpeed > _maxSpeed)
        {
            _projectileSpeed = _maxSpeed;
        }
        base.ThrowProjectile(forceOriginDirection);
    }
    protected override void HitConsequences()
    {
        if(_itemToDrop != null)
        {
            _itemToDrop.enabled = true;
        } else
        {
            DestroyItself();
        }
        _body.velocity = Vector3.zero;
        _body.isKinematic = true;
        if(_pickableCollider != null && transform.parent.GetComponent<Health>() == null)
        {
            _pickableCollider.isTrigger = true;
        }
        else
        {
            DestroyItself();
        }
    }
}
