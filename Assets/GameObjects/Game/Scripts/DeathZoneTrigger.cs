using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZoneTrigger : MonoBehaviour
{
    private int _damage = 100000;

    void OnTriggerExit(Collider target)
    {
        if(target.gameObject.tag == "Player")
        {
            target.gameObject.GetComponent<Health>().Hit(_damage);
        }
    }
}
