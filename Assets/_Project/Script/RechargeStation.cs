using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RechargeStation : MonoBehaviour
{
    private AmmoManager _playerAmmo;
    private void OnTriggerEnter(Collider other) {
        if(other.GetComponent<PlayerInput>() != null)
        {
            _playerAmmo = other.GetComponent<AmmoManager>();
            _playerAmmo.FillUpAmmo();
        }
    }
}
