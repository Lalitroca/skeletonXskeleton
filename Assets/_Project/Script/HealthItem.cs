using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthItem : ItemPickUpBase
{
    private Health _healthManager;
    public override void PickUpItem(GameObject owner)
    {
        _healthManager = owner.GetComponent<Health>();
        if(_healthManager == null)
        {
            return;
        }
        
        _healthManager.GetHealth(_boostAmount);
        base.PickUpItem(owner);
    }
}
