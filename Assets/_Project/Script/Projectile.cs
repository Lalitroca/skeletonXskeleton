using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour, IPoolManager
{
    public float chargedTime = 0f;
    public GameObject owner;
    public float _projectileSpeed;
    [SerializeField] protected float _damage = 30;
    [SerializeField] protected float _lifetime = 25f;
    protected Rigidbody _body;
    protected float _damageMultiplier = 3.5f;
    private Transform _originalParent;

    public void Awake() 
    {
        Initialize();
    }
    public virtual void Initialize()
    {
        if(transform.parent != null)
        {
            _originalParent = transform.parent.transform;
        }
        _body = GetComponent<Rigidbody>();
    }
    public virtual void ThrowProjectile(Vector3 direction)
    {
        Invoke("DestroyItself", _lifetime);
        _body.velocity = direction * _projectileSpeed;
        transform.forward = _body.velocity;
    }
    public void IOnObjectSpawn()
    {
        transform.SetParent(_originalParent);
        _body.isKinematic = false;
    }
    public void DestroyItself()
    {
        gameObject.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<Projectile>() != null)
        {
            other.gameObject.GetComponent<Projectile>().DestroyItself();
            DestroyItself();
            return;
        }
        Damage(other.gameObject);
        transform.SetParent(other.gameObject.transform);
        HitConsequences();
    }
    private void FixedUpdate(){
        if(_body.velocity != Vector3.zero)
        {
            //transform.forward = _body.velocity;
            transform.forward = Vector3.Slerp(transform.forward, _body.velocity, Time.deltaTime);
        }
    }
    private void OnDisable()
    {
        _body.velocity = Vector3.zero;
        owner = null;
    }
    protected virtual void HitConsequences()
    {
        DestroyItself();
    }

    private void Damage(GameObject whoGotHit)
    {
        if(whoGotHit == owner)
        {
            return;
        }
        Health healthScript = whoGotHit.GetComponent<Health>();
        if(healthScript != null)
        {
            _damage += chargedTime * _damageMultiplier;
            healthScript.LoseHealth((int)_damage, gameObject);
        }
    }
}
