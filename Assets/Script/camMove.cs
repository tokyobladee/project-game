using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camMove : MonoBehaviour
{
    public Transform player;
    public float CameraLerpedSpeedScale = 5;
    public Vector3 offset;

    private void FixedUpdate()
        {
            transform.position = Vector3.Lerp(
                transform.position,
                player.position + offset,
                Time.deltaTime * CameraLerpedSpeedScale);
        }
}
