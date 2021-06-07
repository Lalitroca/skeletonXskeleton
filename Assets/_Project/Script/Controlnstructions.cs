using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlnstructions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<PlayerInput>() != null)
        {
            gameObject.SetActive(false);
        }
    }
}
