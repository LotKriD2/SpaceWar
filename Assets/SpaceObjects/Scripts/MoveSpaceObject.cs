using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MoveSpaceObject : MonoBehaviour
{
    [SerializeField] float _speed = 25.0f;

    private GameObject _sun;
    void Start()
    {
        _sun = GameObject.FindGameObjectWithTag("Sun");
    }
    void FixedUpdate()
    {
        transform.RotateAround(_sun.transform.position, Vector3.up, _speed * Time.fixedDeltaTime);
    }
}
