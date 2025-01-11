using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int _hp = 10;
    [SerializeField] protected GameObject _prefabExplosion;

    public void Hit(int damage)
    {
        _hp -= damage;

        if(_hp <= 0)
            Death();
    }

    protected virtual void Death()
    {
        Instantiate(_prefabExplosion, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    public int HP
    {
        get => _hp;
    }
}
