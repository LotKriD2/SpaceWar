using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    [SerializeField] float _speed = 50.0f;
    [SerializeField] float _range = 50.0f;
    [SerializeField] float _detectionRange = 200.0f;

    private Transform _player;
    private PlayerInfo _playerInfo;

    void Awake()
    {
        _playerInfo = GameObject.FindGameObjectWithTag("PlayersBase").GetComponent<PlayerInfo>();
        _player = _playerInfo.GetPlayer().GetComponent<Transform>();
    }

    void FixedUpdate()
    {
        try
        {
            if(CheckDetection())
            {
                transform.position = Vector3.MoveTowards(transform.position, _player.position, _speed * Time.fixedDeltaTime);              
            }
            if(CheckRotateToPlayer())
            {
                transform.LookAt(_player);
            }
        }
        catch (MissingReferenceException)
        {
            if(_playerInfo.IsLife)
            {
                _player = _playerInfo.GetPlayer().GetComponent<Transform>();
            }
        }
    }

    bool CheckDetection()
    {
        if(Vector3.Distance(transform.position, _player.position) >= _range &&
        (_detectionRange == 0 || Vector3.Distance(transform.position, _player.position) <= _detectionRange))
        {
            return true;
        }
        return false;
    }

    bool CheckRotateToPlayer()
    {
        if(_detectionRange == 0 || Vector3.Distance(transform.position, _player.position) <= _detectionRange)
        {
            return true;
        }
        return false;
    }
}
