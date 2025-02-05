using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScaleChangingObstacle : MonoBehaviour
{
    private Vector3 _start;

    private Vector3 _end;

    private float _currentTime;
    [SerializeField]

    private float _frequency = 3f;
    void Start()
    {
        _start = transform.localScale;
        _end = _start*2;
    }
    void Update()
    {
        _currentTime += Time.deltaTime;
        var progress = (Mathf.Sin(_currentTime*_frequency)+1)/2;
        transform.localScale = Vector3.Lerp(_start, _end, progress);
    }
}
