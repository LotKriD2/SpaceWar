using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSpaceObject : MonoBehaviour
{
    [SerializeField] float _rotationSpeed = 10.0f;
    void FixedUpdate()
    {
        transform.Rotate(new Vector3(0, 1, 0) * _rotationSpeed * Time.fixedDeltaTime);
    }
}
