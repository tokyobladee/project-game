using System;
using UnityEngine;

public class Fighter : Mover
{
    public float MaxHealth;
    public float health;
    protected virtual void Attack()
    {
        Debug.Log("Attack");
    }

    protected virtual void TakeDamage(float damage)
    {
        health -= damage;
        Debug.Log($"Health: {health}");
    }

    private void FixedUpdate()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }

        if (health > MaxHealth)
        {
            health = MaxHealth;
        }
    }
}
