using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    private bool _isLife = true;
    private int _countCoin = 0;
    private HealthPlayer _healthPlayer;
    private int _hp = 0;

    public bool IsLife => _isLife;
    public int CountCoint => _countCoin;
    public int HP => _hp;

    private void Start()
    {
        _healthPlayer = GetPlayer().GetComponent<HealthPlayer>();
    }

    private void Update()
    {
        if(!_isLife)
        {
            _healthPlayer = GetPlayer().GetComponent<HealthPlayer>();
        }
        else
        {
            _hp = _healthPlayer.HP;
        }
    }

    public void CheckLife(bool life)
    {
        _isLife = life;
    }

    public void ChangeCountCoin(int value)
    {
        if(value < 0 && IsEnoughCoin(value) ||
           value > 0)
        {
            _countCoin += value;
        }
    }

    private bool IsEnoughCoin(int value)
    {
        if(Mathf.Abs(value) > _countCoin)
        {
            return false;
        }
        return true;
    }

    public GameObject GetPlayer()
    {
        return GameObject.FindGameObjectWithTag("Player");
    }
}
