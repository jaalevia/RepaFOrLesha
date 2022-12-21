using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerMovmentModel 
{
    private Vector2 _movementVector;
    [SerializeField] private float _speed = 10f;
    public Action<Vector2> OnVectorChange;

    public void ChangeVector(float x, float y)
    {
        _movementVector = new Vector2(x * _speed, y * _speed);
        OnVectorChange?.Invoke(_movementVector);
    }


}
