using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    [SerializeField] bool _isSmallEnemy = false;

    private SpawnerEnemy _spawner;

    void Start()
    {
        _spawner = GameObject.FindGameObjectWithTag("EnemiesSpawner").GetComponent<SpawnerEnemy>();
    }

    void OnDestroy()
    {
        _spawner.DeathEnemy(_isSmallEnemy);
    }
}
