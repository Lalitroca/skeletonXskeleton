using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorAttack : EnemyStateAttack
{
    [SerializeField] private int _damage = 50;

    public void AEvHit()
    {
        RegisterPhysicalDamage();
    }

    private void RegisterPhysicalDamage()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, _playerPosition - transform.position, out hit, _enemyController.AttackRange + 0.5f))
        {
            if(hit.transform == transform)
            {
                Debug.Log("why u hitting yourself");
                return;
            }
            Debug.Log("hit " + hit.transform.gameObject.name);
            Health targetHealth = hit.transform.gameObject.GetComponent<Health>();
            if(targetHealth != null)
            {
                targetHealth.LoseHealth(_damage, gameObject);
            }
        }
    }
}
