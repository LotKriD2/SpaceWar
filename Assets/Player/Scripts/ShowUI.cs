using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowUI : MonoBehaviour
{
    [SerializeField] TMP_Text _uiHp;
    [SerializeField] TMP_Text _uiMoney;
    
    private GameObject _player;
    private PlayerInfo _playerInfo;

    void Start()
    {
        _playerInfo = GameObject.FindGameObjectWithTag("PlayersBase").GetComponent<PlayerInfo>();
        _player = _playerInfo.GetPlayer();
    }

    void Update()
    {
        if(_playerInfo.IsLife)
        {
            _player = _playerInfo.GetPlayer();

            _uiHp.text = _playerInfo.HP.ToString();
            _uiMoney.text = _playerInfo.CountCoint.ToString();
        }
    }
}
