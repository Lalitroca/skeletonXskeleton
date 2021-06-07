using UnityEngine;

public class AmmoItem : ItemPickUpBase
{
    private AmmoManager ammoManager;
    public override void PickUpItem(GameObject owner)
    {
        ammoManager = owner.GetComponent<AmmoManager>();
        if(ammoManager == null)
        {
            return;
        }
        
        ammoManager.ChangeAmmoAmmount(_boostAmount);
        base.PickUpItem(owner);
    }
}