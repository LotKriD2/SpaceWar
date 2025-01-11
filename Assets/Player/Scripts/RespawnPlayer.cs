using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPlayer : MonoBehaviour
{
    [SerializeField] GameObject _playerPrefab;

    private bool _isSpawning = false;
    private PlayerInfo _playerInfo;

    void Start()
    {
        _playerInfo = GameObject.FindGameObjectWithTag("PlayersBase").GetComponent<PlayerInfo>();
    }

    void Update()
    {
        if(!_playerInfo.IsLife && !_isSpawning)
        {
            _isSpawning = true;

            Vector3 position = new Vector3(transform.position.x, 0, transform.position.z);
            Instantiate(_playerPrefab, position, Quaternion.identity);
            
            _playerInfo.CheckLife(true);
        }  
        else
        {
            _isSpawning = false;
        } 
    }
}
