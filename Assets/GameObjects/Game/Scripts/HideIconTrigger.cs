using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HideIconTrigger : MonoBehaviour
{
    [SerializeField] GameObject _object;

    void OnTriggerEnter(Collider target)
    {
        if(target.gameObject.tag == "Player")
        {
            _object.SetActive(false);
        }
    }

    void OnTriggerExit(Collider target)
    {
        if(target.gameObject.tag == "Player")
        {
            _object.SetActive(true);
        }
    }
}
