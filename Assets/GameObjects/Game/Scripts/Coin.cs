using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] int _valueCoin;
    [SerializeField] float _lifeTime = 30.0f;

    void Update()
    {
        _lifeTime -= Time.deltaTime;

        if(_lifeTime <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision target)
    {
        if(target.gameObject.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("PlayersBase").GetComponent<PlayerInfo>().ChangeCountCoin(_valueCoin);
            Destroy(gameObject);
        }
    }
}
