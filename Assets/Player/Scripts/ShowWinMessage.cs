using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowWinMessage : MonoBehaviour
{
    [SerializeField] GameObject _uiCongrat;
    [SerializeField] GameObject _mainMenuBtn;
    // Start is called before the first frame update
    private bool _bossIsDead = false;

    public void BossIsDead(bool value)
    {
       _bossIsDead = value;
    }

    void Start()
    {
        _uiCongrat.SetActive(false);
        _mainMenuBtn.SetActive(false);
    }

    void Update()
    {
        if(_bossIsDead)
        {
            Time.timeScale = 0;
            _uiCongrat.SetActive(true);
            _mainMenuBtn.SetActive(true);
        }  
    }
}
