using System;
using UnityEngine;
public class Player : Fighter
{

    public Animator animator;
    private void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        Move(x, y);
        animator.SetFloat("speed", Mathf.Abs(x) + Mathf.Abs(y));
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }
    }
}
