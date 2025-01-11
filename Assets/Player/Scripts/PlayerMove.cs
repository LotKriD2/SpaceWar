using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMove : MonoBehaviour
{
    [SerializeField] float _speed = 50.0f;
    [SerializeField] float _rotationSpeed = 200.0f;
    
    private float _move = 0.0f;
    private Rigidbody _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.W) && _move < 1) 
            _move = 1;
        if(Input.GetKey(KeyCode.S) && _move > 0)
            _move = 0;

        float horizontal = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(0, 0, _move);

        bool move = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D);

        transform.Translate(movement * _speed * Time.fixedDeltaTime);

        //movement = Vector3.ClampMagnitude(movement, _speed);
        //transform.Rotate(Vector3.up, Vector3.Angle(transform.forward, ));
        transform.Rotate(new Vector3(0, horizontal, 0) * _rotationSpeed * Time.fixedDeltaTime);
        if (movement != Vector3.zero)
        {
            //_rb.MovePosition(transform.position + movement * Time.fixedDeltaTime);
            //_rb.Rotate(new Vector3(0, horizontal, 0));
            //_rb.MoveRotation(Quaternion.LookRotation(movement));
        }
    }
}
