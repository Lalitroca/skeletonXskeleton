using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrategicPoint : MonoBehaviour
{
    public Vector3 Position {get; private set;}
    public GameObject AssignedEnemy {get; set;}
    public GameObject owner;

    private void Awake()
    {
        Position = transform.position;
    }

    private void Update() {
        owner = AssignedEnemy;
    }
}
