using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Mover : MonoBehaviour
{
    public float speed = 5;
    private Vector3 moveDelta;
    
    protected virtual void Move(float x, float y)
    {
        moveDelta = new Vector3(x, y, 0);
        moveDelta.Normalize();
        transform.position += moveDelta * speed * Time.deltaTime;
            

    }
}