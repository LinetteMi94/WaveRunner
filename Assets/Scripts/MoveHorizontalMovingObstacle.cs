using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHorizontalMovingObstacle : MonoBehaviour
{
	[SerializeField] private float _speed = 1;
    [SerializeField] private float  _width = 3;
    
    private Vector3 _start;
    private Vector3 _end;
    private float _currentTime;

    void Start()
    {
        _start = new Vector3(-_width, transform.position.y, transform.position.z);
        _end = new Vector3(_width, transform.position.y, transform.position.z);
    }

    void Update()
    {
        _currentTime += Time.deltaTime;
        float progress = Mathf.PingPong(_currentTime, _speed) / _speed;
        transform.position = Vector3.Lerp(_start, _end, progress);       
    }
}


    

