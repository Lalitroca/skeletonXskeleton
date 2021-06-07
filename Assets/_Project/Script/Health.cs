using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private CharacterData _characterinfo = null;
    private CharacterController _characterController;
    private IDamagable[] _damageTrigger;
    public virtual void Initialize()
    {
        Debug.Log(this + " intialized");
        _damageTrigger = GetComponents<IDamagable>();
        _characterController = GetComponent<CharacterController>();
    }

    public virtual void ResetHealth()
    {
        CurrentHealth = _characterinfo.baseHealth;
    }
    public void GetHealth(int amount)
    {
        CurrentHealth += amount;
    }

    public void LoseHealth(int amount, GameObject striker)
    {
        Debug.Log(gameObject.name + " lost " + amount + " of health");
        CurrentHealth -= amount;
        if(CurrentHealth <= 0)
        {
            OutOfHealth();
        }
        else if(_damageTrigger != null)
        {
            foreach(IDamagable trigger in _damageTrigger)
            {
                trigger.IOnDamaged(striker);
            }
        }
    }
    protected virtual void OutOfHealth()
    {
        Debug.Log(gameObject.name + " reached zero health");
        if(_characterController != null)
        {
            _characterController.Death();
        }
    }
    private void OnEnable()
    {
        ResetHealth();
    }
    public int CurrentHealth { get; set;}
}
