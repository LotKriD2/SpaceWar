using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootEnemy : MonoBehaviour
{
    [SerializeField] GameObject _bulletPrefab;
    [SerializeField] Transform _firePoint;
    [SerializeField] float _attackRange = 70.0f;
    [SerializeField] float _reloadTime = 20.0f;

    private float _reload = 0;
    private Transform _player;
    private PlayerInfo _playerInfo;

    void Awake()
    {
        _playerInfo = GameObject.FindGameObjectWithTag("PlayersBase").GetComponent<PlayerInfo>();
        _player = _playerInfo.GetPlayer().GetComponent<Transform>();
    }

    void FixedUpdate()
    {
        _reload -= Time.fixedDeltaTime;

        if(_reload <= 0 && SeePlayer())
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(_bulletPrefab, _firePoint.position, _firePoint.rotation);
        _reload = _reloadTime;
    }

    bool SeePlayer()
    {
        try
        {
            if(Vector3.Distance(transform.position, _player.position) <= _attackRange)
            {
                return true;
            }
            return false;
        }
        catch (MissingReferenceException)
        {
            if(_playerInfo.IsLife)
            {
                _player = _playerInfo.GetPlayer().GetComponent<Transform>();
            }
            return false;
        }
    }
}
