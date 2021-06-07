using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapCamFollow : MonoBehaviour
{
    private Vector3 camPos;
    [SerializeField] private float camHeight = 3;
    [SerializeField] private float maxXPos = 26f;
    [SerializeField] private float minXPos = 13.5f;
    [SerializeField] private float maxZPos = 29f;
    [SerializeField] private float minZPos = 10.5f;
    private void FixedUpdate()
    {
        camPos = Camera.main.transform.position;
        transform.position = new Vector3(Mathf.Clamp(camPos.x, minXPos, maxXPos), camPos.y + camHeight, Mathf.Clamp(camPos.z, minZPos, maxZPos));
    }
}
