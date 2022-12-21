using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementView : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb;
    public void UpdatePlayerView(Vector2 newVector)
    {
        _rb.velocity = newVector;
    }
}
