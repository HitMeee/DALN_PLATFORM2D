using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    public int maxHealth = 1;
    protected int health;

    protected virtual void Awake()
    {
        health = maxHealth;
    }

    public virtual void TakeDamage(int amount = 1)
    {
        health -= amount;
        if (health <= 0)
            Die();
    }

    public virtual void Die()
    {
        SpawnDrop();
        Destroy(gameObject);
    }

    protected virtual void SpawnDrop()
    {
    }
}