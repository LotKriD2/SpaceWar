using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPlayer : Health
{
    protected override void Death()
    {
        Instantiate(_prefabExplosion, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    void OnDestroy()
    {
        GameObject.FindGameObjectWithTag("PlayersBase").GetComponent<PlayerInfo>().CheckLife(false);
    }
}