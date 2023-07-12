using UnityEngine;

public class Fighter : Mover
{
    public float health { get; private set; }

    protected virtual void Attack()
    {
        Debug.Log("Attack");
    }

    protected virtual void TakeDamage(float damage)
    {
        health -= damage;
        Debug.Log($"Health: {health}");
    }
}
