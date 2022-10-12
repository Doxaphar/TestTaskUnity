using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private InputController inputController;

    [SerializeField] private GameObject cubePrefab;

    private float _time, _speed, _distance;
    private float _tempTime, _tempSpeed, _tempDistance;
    private double _elapsedTime;

    private void Update()
    {
        (_tempTime, _tempSpeed, _tempDistance) = inputController.GetInput();
        if (_tempTime != 0 && _tempSpeed != 0 && _tempDistance != 0)
        {
            _time = _tempTime;
            _speed = _tempSpeed;
            _distance = _tempDistance;
        }
    }

    private void FixedUpdate()
    {
        var target = transform.position + Vector3.forward * _distance;
        if (_time != 0 && _speed != 0 && _distance != 0)
        {
            _elapsedTime += Time.fixedDeltaTime;
            if (_elapsedTime >= _time)
            {
                _elapsedTime = 0;
                var tempCube = Instantiate(cubePrefab, transform.position, Quaternion.identity).GetComponent<CubeMove>();
                tempCube.speed = _speed;
                tempCube.target = target;
            }
        }
    }
}
