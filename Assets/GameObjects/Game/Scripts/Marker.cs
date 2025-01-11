using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marker : MonoBehaviour
{
    [SerializeField] Transform _target;
    
    void Update()
    {
        transform.position = new Vector3(_target.position.x, _target.position.y, _target.position.z);
    }
}
