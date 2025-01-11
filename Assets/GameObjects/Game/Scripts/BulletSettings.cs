using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSettings : MonoBehaviour
{
    [SerializeField] float _speed = 100.0f;
    [SerializeField] int _maxTime = 50;
    [SerializeField] GameObject _prefabExplosion;

    private int _time = 0;


    void FixedUpdate()
    {
        _time++;
        
        Vector3 movement = new Vector3(0, 0, 1);
        transform.Translate(movement * _speed * Time.fixedDeltaTime);
        
        if(_time >= _maxTime)
        {
            Destroy(gameObject);
            _time = 0;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag != gameObject.GetComponent<Damage>().IgnoreTag)
        {
            Instantiate(_prefabExplosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
