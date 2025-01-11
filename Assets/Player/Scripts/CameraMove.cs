using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraMove : MonoBehaviour
{
    [SerializeField] float _speed = 50.0f;
    [SerializeField] float _offset = 50.0f;

    private GameObject _player;
    private PlayerInfo _playerInfo;

    void Start()
    {
        _playerInfo = GameObject.FindGameObjectWithTag("PlayersBase").GetComponent<PlayerInfo>();
    }

    void FixedUpdate()
    {
        if(_playerInfo.IsLife)
        {
            _player = GameObject.FindGameObjectWithTag("Player");
            
            Vector3 movement = new Vector3(_player.transform.position.x, _offset, _player.transform.position.z);
        
            transform.position = movement * _speed * Time.fixedDeltaTime;
        }
    }
}