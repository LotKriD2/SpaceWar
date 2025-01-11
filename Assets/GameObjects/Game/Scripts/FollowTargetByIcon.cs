using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTargetByIcon : MonoBehaviour
{
    [SerializeField] float _speed = 100.0f;

    [SerializeField] float _maxX = 200.0f;
    [SerializeField] float _minX = -200.0f;
    [SerializeField] float _maxY = 200.0f;
    [SerializeField] float _minY = -200.0f;

    [SerializeField] RectTransform _marker;

    private RectTransform _rec;

    private float _delta = 0.1f;

    void Start()
    {
        _rec = gameObject.GetComponent<RectTransform>();
    }

    void FixedUpdate()
    {
        CheckBorders();
        _rec.anchoredPosition = Vector2.MoveTowards(_rec.anchoredPosition, _marker.anchoredPosition, _speed * Time.fixedDeltaTime); 
    }

    void CheckBorders()
    {
        if(_rec.anchoredPosition.x >= _maxX)
        {
            _rec.anchoredPosition = new Vector2(_maxX - _delta, _rec.anchoredPosition.y);
        }
        else if(_rec.anchoredPosition.x <= _minX)
        {
            _rec.anchoredPosition = new Vector2(_minX + _delta, _rec.anchoredPosition.y);
        }
        if(_rec.anchoredPosition.y >= _maxY)
        {
            _rec.anchoredPosition = new Vector2(_rec.anchoredPosition.x, _maxY - _delta);
        }
        else if(_rec.anchoredPosition.y <= _minY)
        {
            _rec.anchoredPosition = new Vector2(_rec.anchoredPosition.x, _minY + _delta);
        }
    }
}
