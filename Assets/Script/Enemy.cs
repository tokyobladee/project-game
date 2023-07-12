using System;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Enemy : Fighter
{
    private Vector2 Direction;

    private void Start()
    {
        InvokeRepeating(nameof(GetDirection),0f, 5f);
    }

    private void FixedUpdate()
    {
        Move(Direction.x, Direction.y);
    }

    private void GetDirection()
    {
        Direction = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
    }
    
}
