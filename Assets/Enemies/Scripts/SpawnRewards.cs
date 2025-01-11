using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRewards : MonoBehaviour
{
    [SerializeField] GameObject _prefabCoin;
    
    void OnDestroy()
    {
        Vector3 position = new Vector3(transform.position.x, 0, transform.position.z);
        Instantiate(_prefabCoin, position, Quaternion.identity);
    }
}
