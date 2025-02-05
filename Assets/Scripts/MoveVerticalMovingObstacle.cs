using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveVerticalMovingObstacle : MonoBehaviour
{
    private Vector3 _start;

    private Vector3 _end;

    private float _currentTime;
    void Start()
    {
        _start = transform.position;
        _end = new Vector3(transform.position.x,transform.position.y-5,transform.position.z);
    }
    void Update()
    {
        _currentTime += Time.deltaTime;
        var progress = Mathf.PingPong(_currentTime,1);
        transform.position = Vector3.Lerp(_start, _end, progress);
    }
}
