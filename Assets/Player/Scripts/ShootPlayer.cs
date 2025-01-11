using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPlayer : MonoBehaviour
{
    [SerializeField] GameObject _bulletPrefab;
    [SerializeField] Transform _firePoint;

    private bool _isSpawning = false;
    private int _reloadTime = 10;

    void FixedUpdate()
    {
        _reloadTime--;
        if(_reloadTime <= 0)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        if(!_isSpawning && Input.GetKey(KeyCode.Space))
        {
            _isSpawning = true;
            Instantiate(_bulletPrefab, _firePoint.position, _firePoint.rotation);
            _reloadTime = 10;
        }
        else if(!Input.GetKey(KeyCode.Space))
        {
            _isSpawning = false;
        }
    }

}
