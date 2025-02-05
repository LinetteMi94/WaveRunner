using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRotatingObstacle : MonoBehaviour
{
   [SerializeField] private float _speed = 100;
   private Vector3 _rotation;

   void Start()
   {
      _rotation = new Vector3(0, 0, _speed);
   }

   void Update()
   {
      transform.Rotate(_rotation * Time.deltaTime, Space.Self);
   }
}
