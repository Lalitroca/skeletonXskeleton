using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementStruct
{
    public struct MovementInfo
    {
        public bool moving;
        public Vector3 direction;
        public bool running;
        public bool jumping;
        public float speed;
    }
}
