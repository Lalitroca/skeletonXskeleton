using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.UI;

public class AimUIControl : MonoBehaviour
{
    [SerializeField] private Slider _aimStrength = null;
    [SerializeField] private Animator _aimStrenghtAnimator = null;

    public void ShowCharge(bool show)
    {
        _aimStrength.gameObject.SetActive(show);
    }
    public void UpdateAimBarValue(float value)
    {
        _aimStrength.value = value;
        if(_aimStrength.gameObject.activeSelf)
        {
            _aimStrenghtAnimator.SetFloat("FillPercentage", _aimStrength.value);
        }
    }
}
