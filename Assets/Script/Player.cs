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
        animator.SetFloat("vertical", y);
        animator.SetFloat("horizontal", Mathf.Abs(x));
        animator.SetFloat("attack", Input.GetAxisRaw("Fire1"));
        if (x < -0.1f)
        {
            transform.localScale = new Vector3(-1.8648f, 1.7158f, 1);
        }else if(x > 0.1f)
        {
            transform.localScale = new Vector3(1.8648f, 1.7158f, 1);
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }
    }
}
