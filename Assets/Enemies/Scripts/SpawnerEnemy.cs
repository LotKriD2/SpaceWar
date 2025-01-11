using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerEnemy : MonoBehaviour
{
    [SerializeField] int _maxEnemy = 15;
    [SerializeField] int _maxSmallEnemy = 5;
    [SerializeField] int _spawnAreaX = 30;
    [SerializeField] int _spawnAreaZ = 30;
    [SerializeField] float _spawnTime = 10.0f;

    [SerializeField]GameObject[] _enemiesSmallPrefabs;
    [SerializeField] GameObject[] _enemiesPrefabs;

    
    private int _countEnemies = 0;
    private int _countSmallEnemies = 0;
    private float _timer = 0;

    void Update()
    {
        _timer -= Time.deltaTime;

        if(_timer <= 0 && _countEnemies < _maxEnemy)
        {
            Spawn();
            _timer = _spawnTime;
        }
    }

    void Spawn()
    {
        _countEnemies++;

        Vector3 position = GeneratePosition();
        
        GameObject enemy = GetEnemyPrefab();

        Instantiate(enemy, position, Quaternion.identity); 
    }

    Vector3 GeneratePosition()
    {
        int x = Random.Range(-_spawnAreaX, _spawnAreaX);
        int z = Random.Range(-_spawnAreaZ,_spawnAreaZ);

        return new Vector3(transform.position.x + x, 0, transform.position.z + z);
    }

    GameObject GetEnemyPrefab()
    {
        int index;

        if(_countSmallEnemies < _maxSmallEnemy)
        {
            _countSmallEnemies++;

            index = Random.Range(0, _enemiesSmallPrefabs.Length - 1);

            return _enemiesSmallPrefabs[index];
        }
        
        index = Random.Range(0, _enemiesPrefabs.Length - 1);

        return _enemiesPrefabs[index];
    }

    public void DeathEnemy(bool isSmallEnemy)
    {
        _countEnemies--;

        if(isSmallEnemy)
        {
            _countSmallEnemies--;
        }
    }
}
