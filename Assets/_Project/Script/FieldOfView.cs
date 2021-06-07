using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldOfView : MonoBehaviour
{
    [SerializeField] private float _viewDistance = 10;
    [SerializeField] private int _rayAmmount = 10;
    [SerializeField] private float _viewAngle = 150;
    [SerializeField] private Transform _eyes = null;
    private List<Ray> _rays = new List<Ray>();
    
    public bool findInFieldOfView(GameObject target, out Vector3 targetPosition)
    {
        _rays.Clear();
        if(_eyes == null)
        {
            Debug.Log("No eyes");
            _eyes = transform;
        }
        
        for(int i = -_rayAmmount/2; i < _rayAmmount/2; i++)
        {
            Vector3 direction = Quaternion.AngleAxis(_viewAngle/_rayAmmount * i, Vector3.up) * transform.forward;
            _rays.Add(new Ray(_eyes.position, direction));
            Debug.DrawRay(_eyes.position, direction * _viewDistance, Color.red);
        }
        foreach(Ray ray in _rays)
        {
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit, _viewDistance))
            {
                if (hit.collider.gameObject == target)
                {
                    transform.LookAt(target.transform);
                    targetPosition = hit.collider.transform.position;
                    return true;
                }
            }
        }
        targetPosition = Vector3.zero;
        return false;
    }
}
