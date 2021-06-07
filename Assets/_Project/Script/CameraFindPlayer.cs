using UnityEngine;
using Cinemachine;


public class CameraFindPlayer : MonoBehaviour
{
    private CinemachineVirtualCamera mainCamera;
    
    public void setCamFollow(GameObject whoToFollow)
    {
        mainCamera = GetComponent<CinemachineVirtualCamera>();
        if(mainCamera != null && whoToFollow != null)
        {
            mainCamera.Follow = whoToFollow.transform;
        }
    }
}
