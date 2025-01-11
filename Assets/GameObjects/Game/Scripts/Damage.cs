using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField] int _damage = 10;
    [SerializeField] GameObject _ignoreTag;

    void OnCollisionEnter(Collision target)
    {
        try
        {
            if(target.gameObject.tag != _ignoreTag.tag)
            {
                target.gameObject.GetComponent<Health>().Hit(_damage);
            }
        }
        catch (System.NullReferenceException)
        {
            Debug.Log("<-Target is dead->");
        }        
    }

    public string IgnoreTag
    {
        get => _ignoreTag.tag;
    }
}
