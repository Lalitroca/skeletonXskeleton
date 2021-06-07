using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffinAnimator : MonoBehaviour
{
    [SerializeField] private float _riseSpeed = 0.3f;
    [SerializeField] private Animator _anim = null;
    private float height;
    
    public void OpenCoffin()
    {
        _anim.SetTrigger(AnimatorParameters.COFFIN_OPEN);
    }

    public void CloseCoffin()
    {
        _anim.SetTrigger(AnimatorParameters.COFFIN_CLOSE);
    }

    public void RiseCoffin(bool rise)
    {
        if(rise)
        {
            height = 0;
        }
        else
        {
            height = 1;
        }
        _anim.SetBool(AnimatorParameters.COFFIN_ISRISING, true);
        RiseGradually();
    }

    private void RiseGradually()
    {
        if(height == 0)
        {
            while(height <= 1)
            {
                height += _riseSpeed;
                _anim.SetFloat(AnimatorParameters.COFFIN_RISEHEIGHT, height);
            }
            height = 1;
            _anim.SetBool(AnimatorParameters.COFFIN_ISRISING, false);
            _anim.SetFloat(AnimatorParameters.COFFIN_RISEHEIGHT, height);
        }
        else if(height == 1)
        {
            while(height >= 0)
            {
                height -= _riseSpeed;
                _anim.SetFloat(AnimatorParameters.COFFIN_RISEHEIGHT, height);
            }
            height = 0;
            _anim.SetBool(AnimatorParameters.COFFIN_ISRISING, false);
            _anim.SetFloat(AnimatorParameters.COFFIN_RISEHEIGHT, height);
        }
    }
}
