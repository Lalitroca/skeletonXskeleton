using System.Collections;
using UnityEngine;
using Cinemachine;
public class CameraAnimation : CinemachineExtension
{
    public float m_Range = 0.5f;
    public float m_ShakeSpeed = 0.5f;
    private Vector3 _offset;
 
    protected override void OnEnable() {
        InvokeRepeating("ChangeOffset", 0, m_ShakeSpeed * 0.005f);
    }
    protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
    {
        if (stage == CinemachineCore.Stage.Body)
        {
            Vector3 shakeAmount = _offset;
            state.PositionCorrection += shakeAmount;
        }
    }
 
    private Vector3 GetOffset()
    {
        return new Vector3 (1, Random.Range(-m_Range, m_Range), 1);
    }

    private void ChangeOffset()
    {
        _offset = new Vector3 (0, Random.Range(-m_Range, m_Range), 0);
    }
}
