using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldController : Health
{
    [SerializeField] private int _initalHealth = 60;
    [SerializeField] private ShieldedEnemyController _manager = null;
    [SerializeField] private GameObject _visualShield = null;
    private ParticleSystem _particleSystem;
    public override void Initialize()
    {
        _particleSystem = GetComponent<ParticleSystem>();
    }
    public override void ResetHealth()
    {
        CurrentHealth = _initalHealth;
        _visualShield.SetActive(true);
    }
    protected override void OutOfHealth()
    {
        _particleSystem.Play();
        _manager.LoseShield();
        _visualShield.SetActive(false);
    }
}
